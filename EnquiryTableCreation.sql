-- Table: public.enquiry

-- DROP TABLE IF EXISTS public.enquiry;

CREATE TABLE IF NOT EXISTS public.enquiry
(
    id integer NOT NULL GENERATED ALWAYS AS IDENTITY ( INCREMENT 1 START 1 MINVALUE 1 MAXVALUE 2147483647 CACHE 1 ),
    first_name character varying(30) COLLATE pg_catalog."default" NOT NULL,
    last_name character varying(30) COLLATE pg_catalog."default" NOT NULL,
    mobile_no character varying(50) COLLATE pg_catalog."default",
    email character varying(25) COLLATE pg_catalog."default" NOT NULL,
    message character varying(150) COLLATE pg_catalog."default" NOT NULL,
    CONSTRAINT enquiry_pkey PRIMARY KEY (id)
)

TABLESPACE pg_default;

ALTER TABLE IF EXISTS public.enquiry
    OWNER to postgres;