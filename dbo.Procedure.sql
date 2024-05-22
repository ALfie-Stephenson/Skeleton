CREATE PROCEDURE sproc_tblCustomer_FilterByCustomerNo
   --parameter to store the customer no we are looking for
   @CustomerNo int
AS
    --select all fields from the table where the customer no matches the parameter data
    SELECT * FROM tblCustomer WHERE CustomerNo = @CustomerNo

RETURN 0
