

create user thinh identified by thinh
grant create session to thinh
grant create table to thinh
alter user thinh quota 500M on users


----cấp quyền tạo trigger
GRANT CREATE TRIGGER TO THINH;
GRANT CREATE ANY TRIGGER TO THINH;


----------------------------------------------------------------------------------------------
CREATE OR REPLACE PROCEDURE sys.logout_user(p_username VARCHAR2)
AUTHID DEFINER
IS
BEGIN
   FOR r IN (
      SELECT sid, serial#
      FROM v$session
      WHERE username = UPPER(p_username)
        AND sid <> (SELECT sid FROM v$mystat WHERE ROWNUM = 1)
   )
   LOOP
      EXECUTE IMMEDIATE 'ALTER SYSTEM KILL SESSION ''' 
                         || r.sid || ',' || r.serial# || ''' IMMEDIATE';
   END LOOP;
END;
/
GRANT EXECUTE ON SYS.LOGOUT_USER TO thinh; 
GRANT CREATE TABLE TO THINH;


CREATE OR REPLACE PROCEDURE logout_user_all IS
BEGIN
   FOR r IN (
      SELECT sid, serial#
      FROM v$session
      WHERE username IS NOT NULL
        AND sid <> (SELECT sid FROM v$mystat WHERE ROWNUM = 1)  -- bá» qua session hiá»‡n táº¡i
   )
   LOOP
      EXECUTE IMMEDIATE 'ALTER SYSTEM KILL SESSION ''' 
                         || r.sid || ',' || r.serial# || ''' IMMEDIATE';
   END LOOP;
END;
/

CREATE OR REPLACE PROCEDURE CHANGE_PASSWORD(p_username varchar2, p_new_pass varchar2) IS
BEGIN
    EXECUTE IMMEDIATE 'ALTER USER ' || p_username || ' IDENTIFIED BY ' || p_new_pass;
    EXCEPTION
        WHEN OTHERS THEN 
                RAISE_APPLICATION_ERROR(-20001, 'KhÃ´ng thá»ƒ Ä‘á»•i máº­t kháº©u cho user ' || p_username || 
                                       '. Lá»—i: ' || SQLERRM);
END;
















