--PostgreSQL
CREATE TABLE public.wells
(
    id integer,
    name character varying(256) NOT NULL,
    PRIMARY KEY (id)
)
WITH (
    OIDS = FALSE
)
TABLESPACE pg_default;

ALTER TABLE public.wells
    OWNER to test;