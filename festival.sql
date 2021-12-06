-- Database til festival

CREATE TABLE by (
    by_id bigserial PRIMARY KEY,
    by varchar(50),
    last_update timestamp with time zone DEFAULT CURRENT_TIMESTAMP
);

CREATE TABLE adresse (
    adresse_id bigserial PRIMARY KEY,
    adresse varchar(255),
    telefon int,
    by_id int REFERENCES by (by_id),
    last_update timestamp with time zone DEFAULT CURRENT_TIMESTAMP
);

CREATE TABLE rolle (
    rolle_id serial PRIMARY KEY,
    navn varchar(50) NOT NULL,
    last_update timestamp with time zone DEFAULT CURRENT_TIMESTAMP
);

CREATE TABLE bruger (
    bruger_id bigserial PRIMARY KEY,
    fornavn varchar(50) NOT NULL,
    efternavn varchar(50) NOT NULL,
    foedselsdato date NOT NULL,
    adresse_id int REFERENCES adresse (adresse_id),
    rolle_id smallint REFERENCES rolle (rolle_id),
    aktiv boolean DEFAULT true,
    email varchar(50) NOT NULL,
    username varchar(50) UNIQUE,
    pswhash varchar(255),
    last_update timestamp with time zone DEFAULT CURRENT_TIMESTAMP
);

CREATE TABLE opgavedetalje (
    opgavedetalje_id bigserial PRIMARY KEY,
    opgavedetalje varchar(50),
    beskrivelse text,
    last_update timestamp with time zone DEFAULT CURRENT_TIMESTAMP
);

CREATE TABLE placering (
    placering_id serial PRIMARY KEY,
    placering varchar(255) NOT NULL,
    last_update timestamp with time zone DEFAULT CURRENT_TIMESTAMP
);

CREATE TABLE status (
    status_id serial PRIMARY KEY,
    status varchar(50),
    last_update timestamp with time zone DEFAULT CURRENT_TIMESTAMP
);

CREATE TABLE opgave (
    opgave_id bigserial PRIMARY KEY,
    opgavedetalje_id int REFERENCES opgavedetalje (opgavedetalje_id),
    placering_id int REFERENCES placering (placering_id),
    status_id smallint REFERENCES status (status_id),
    last_update timestamp with time zone DEFAULT CURRENT_TIMESTAMP
);

CREATE TABLE vagt (
    vagt_id bigserial PRIMARY KEY,
    starttid timestamp with time zone NOT NULL,
    sluttid timestamp with time zone NOT NULL,
    opgave_id int REFERENCES opgave (opgave_id),
    bruger_id int REFERENCES bruger (bruger_id),
    last_update timestamp with time zone DEFAULT CURRENT_TIMESTAMP
);

CREATE TABLE event_type (
    event_id serial PRIMARY KEY,
    navn varchar(50) NOT NULL
);

CREATE TABLE audit_log (
    log_id serial PRIMARY KEY,
    event_type smallint NOT NULL,
    table_name varchar(50) NOT NULL,
    bruger varchar(100) NOT NULL,
    "timestamp" timestamp with time zone NOT NULL
);

CREATE OR REPLACE FUNCTION audit_bruger_data()
    RETURNS trigger
    LANGUAGE plpgsql
AS $$
DECLARE
    eventType smallint;
    bruger_navn text;
BEGIN 
    IF (TG_OP = 'TRUNCATE') THEN 
        eventType := 4;
        bruger_navn := CONCAT(OLD.fornavn, ' ', OLD.efternavn);
    ELSIF (TG_OP = 'DELETE') THEN
        eventType := 3;
        bruger_navn := CONCAT(OLD.fornavn, ' ', OLD.efternavn);
    ELSIF (TG_OP = 'UPDATE') THEN
        eventType := 2;
        bruger_navn := CONCAT(NEW.fornavn, ' ', NEW.efternavn);
    ELSIF (TG_OP = 'INSERT') THEN
        eventType := 1;
        bruger_navn := CONCAT(NEW.fornavn, ' ', NEW.efternavn);
    END IF;

    INSERT INTO audit_log (event_type, table_name, bruger, timestamp)
    VALUES (eventType, TG_TABLE_NAME, bruger_navn, now());

    RETURN NEW;
END;
$$;

CREATE TRIGGER audit_bruger_table
    AFTER INSERT OR UPDATE OR DELETE
    ON bruger
    FOR EACH ROW EXECUTE FUNCTION audit_bruger_data();

CREATE OR REPLACE FUNCTION public.last_updated()
    RETURNS trigger
    LANGUAGE 'plpgsql'
    COST 100
    VOLATILE NOT LEAKPROOF
AS $BODY$
BEGIN
    NEW.last_update = CURRENT_TIMESTAMP;
    RETURN NEW;
END 
$BODY$;

ALTER FUNCTION public.last_updated()
    OWNER TO postgres;

CREATE TRIGGER last_updated
    BEFORE UPDATE 
    ON public.by
    FOR EACH ROW
    EXECUTE FUNCTION public.last_updated();

CREATE TRIGGER last_updated
    BEFORE UPDATE 
    ON public.adresse
    FOR EACH ROW
    EXECUTE FUNCTION public.last_updated();

CREATE TRIGGER last_update
    BEFORE UPDATE
    ON public.rolle
    FOR EACH ROW
    EXECUTE FUNCTION public.last_updated();

CREATE TRIGGER last_updated
    BEFORE UPDATE 
    ON public.bruger
    FOR EACH ROW
    EXECUTE FUNCTION public.last_updated();

CREATE TRIGGER last_updated
    BEFORE UPDATE 
    ON public.opgavedetalje
    FOR EACH ROW
    EXECUTE FUNCTION public.last_updated();

CREATE TRIGGER last_updated
    BEFORE UPDATE 
    ON public.placering
    FOR EACH ROW
    EXECUTE FUNCTION public.last_updated();

CREATE TRIGGER last_updated
    BEFORE UPDATE 
    ON public.status
    FOR EACH ROW
    EXECUTE FUNCTION public.last_updated();

CREATE TRIGGER last_updated
    BEFORE UPDATE 
    ON public.opgave
    FOR EACH ROW
    EXECUTE FUNCTION public.last_updated();

CREATE TRIGGER last_updated
    BEFORE UPDATE 
    ON public.vagt
    FOR EACH ROW
    EXECUTE FUNCTION public.last_updated();

INSERT INTO by (by)
VALUES  ('Aarhus'),
        ('Skanderborg'),
        ('Horsens'),
        ('Randers');

INSERT INTO adresse (adresse, telefon, by_id)
VALUES  ('Egevej 2', 21345678, 1),
        ('Granvej 4', 22345678, 1),
        ('Løvvej 5', 23345678, 2),
        ('Fyrvej 3', 24345678, 2);

INSERT INTO rolle (navn)
VALUES  ('Frivillig'),
        ('Koordinator');

-- Opret bruger med kodeord vha. HASH- og SALT-strenge.
-- https://www.postgresql.org/docs/8.3/pgcrypto.html
CREATE EXTENSION pgcrypto;

INSERT INTO bruger (fornavn, efternavn, foedselsdato, adresse_id, rolle_id, email, username, pswhash)
VALUES  ('Jacob', 'Wolter', '2000-01-01', 2, 1, 'eaajwg@students.eaaa.dk', 'jacobw', crypt('jacobsKodeord', gen_salt('bf'))),
        ('Martin', 'Pham', '2000-01-01', 3, 1, 'eaammph@students.eaaa.dk', 'martinp', crypt('martinsKodeord', gen_salt('bf'))),
        ('Jesper', 'Møller', '2000-01-01', 4, 1, 'eaahjvn@students.eaaa.dk', 'jesperm', crypt('jespersKodeord', gen_salt('bf'))),
        ('Victor', 'Pascale', '2000-01-01', 1, 2, 'eaavap@students.eaaa.dk', 'victorp', crypt('victorsKodeord', gen_salt('bf')));

INSERT INTO opgavedetalje (opgavedetalje)
VALUES  ('servicepersonale'),
        ('salg af drikkevarer'),
        ('crowd safety'),
        ('rengøring');

INSERT INTO placering (placering)
VALUES  ('Campingområde A'),
        ('Campingområde B'),
        ('Scene A'),
        ('Scene B');

INSERT INTO status (status)
VALUES  ('i planlægning'),
        ('i udførelse'),
        ('udført');

INSERT INTO opgave (opgavedetalje_id, placering_id, status_id)
VALUES  (1, 1, 1),
        (1, 2, 1),
        (2, 1, 1),
        (2, 2, 1),
        (3, 3, 1),
        (3, 4, 1),
        (4, 1, 1),
        (4, 2, 1);

INSERT INTO vagt (starttid, sluttid, opgave_id)
VALUES  ('2022-02-20 08:00:00', '2022-02-20 15:00:00', 1),
        ('2022-02-20 15:00:00', '2022-02-21 01:00:00', 1);

CREATE OR REPLACE FUNCTION verificer_bruger(username varchar(50), password varchar(50))
    RETURNS boolean
    LANGUAGE plpgsql
AS $$
BEGIN 
    RETURN (
        SELECT pswhash = crypt(password, pswhash)
        FROM bruger
        WHERE bruger.username = verificer_bruger.username
    );
END;
$$;

CREATE OR REPLACE VIEW ledige_vagter AS
    SELECT vagt_id, starttid, sluttid, opgavedetalje, placering
    FROM vagt JOIN opgave
    ON vagt.opgave_id = opgave.opgave_id
    JOIN placering
    ON opgave.placering_id = placering.placering_id
    JOIN opgavedetalje
    ON opgave.opgavedetalje_id = opgavedetalje.opgavedetalje_id
    FULL JOIN bruger
    ON bruger.bruger_id = vagt.bruger_id
    WHERE vagt_id IS NOT NULL AND fornavn IS NULL;
   
-- SELECT * FROM ledige_vagter;

INSERT INTO event_type (navn)
VALUES  ('insert'),
        ('update'),
        ('delete'),
        ('truncate');

CREATE OR REPLACE VIEW audit_bruger_data AS
    SELECT log_id, navn, bruger, timestamp
    FROM audit_log JOIN event_type
    ON audit_log.event_type = event_type.event_id;
