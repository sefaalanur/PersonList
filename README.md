# PersonList
The application has the functionality of a simple contact book in particular it allows:  
1. Saving person data such as: name, surname, telephone number, email address, date of birth.  
2. Display birthday in the current week.  
3. Ability to edit individual contacts.  
4. Delete the selected contact.  
5. Ability to add new person on the list.

The project is written in Visual Studio.It includes .Net Framework c#, windows form application and Postgres
All the datas are saved in my database PostgreSQL:
-- Table: public.persons
-- DROP TABLE IF EXISTS public.persons;
CREATE TABLE IF NOT EXISTS public.persons
(
    id integer NOT NULL GENERATED ALWAYS AS IDENTITY ( INCREMENT 1 START 1 MINVALUE 1 MAXVALUE 2147483647 CACHE 1 ),
    name text COLLATE pg_catalog."default",
    surname text COLLATE pg_catalog."default",
    phone text COLLATE pg_catalog."default",
    email text COLLATE pg_catalog."default",
    birthday timestamp with time zone,
    CONSTRAINT persons_pkey PRIMARY KEY (id)
)
TABLESPACE pg_default;
ALTER TABLE IF EXISTS public.persons
    OWNER to postgres;
    
    User can just add, edit and delete any person from the contact book by just clicking the buttons and display the birthdays in current week and check the 
list after all the transactions.
    
