-- Table: public.book_appointment

-- DROP TABLE IF EXISTS public.book_appointment;

CREATE TABLE IF NOT EXISTS public.book_appointment
(
    id integer NOT NULL GENERATED ALWAYS AS IDENTITY ( INCREMENT 1 START 1 MINVALUE 1 MAXVALUE 2147483647 CACHE 1 ),
    first_name character varying(30) COLLATE pg_catalog."default" NOT NULL,
    last_name character varying(30) COLLATE pg_catalog."default" NOT NULL,
    gender character varying(10) COLLATE pg_catalog."default" NOT NULL,
    address character varying(100) COLLATE pg_catalog."default" NOT NULL,
    mobile_no character varying(50) COLLATE pg_catalog."default" NOT NULL,
    email character varying(25) COLLATE pg_catalog."default" NOT NULL,
    doctor_name character varying(25) COLLATE pg_catalog."default" NOT NULL,
    speciality character varying(25) COLLATE pg_catalog."default" NOT NULL,
    appointment_date date NOT NULL,
    appointment_time time without time zone NOT NULL,
    CONSTRAINT book_appointment_two_pkey PRIMARY KEY (id)
)

TABLESPACE pg_default;

ALTER TABLE IF EXISTS public.book_appointment
    OWNER to postgres;