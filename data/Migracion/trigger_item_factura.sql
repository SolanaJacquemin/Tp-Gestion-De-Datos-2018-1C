create trigger t2 on FOUR_SIZONS.Item_Factura
instead of insert
as
begin
	declare @nroitem as numeric(18)
	declare @nroitemn as numeric(18)
	
	declare @facnro as numeric(18)
	declare @cant as numeric(18)
	declare @monto as decimal(18,2)

	declare @facnroant as numeric(18)
	set @nroitemn = 1

	select top 1 @facnro = Factura_Nro, @nroitem = Item_Factura_NroItem, @cant = Item_Factura_Cant, @monto = Item_Factura_Monto 
	from inserted
	order by Item_Factura_NroItem desc

	if  exists (select * from FOUR_SIZONS.Item_Factura where Factura_Nro = @facnro)
	begin
		select @nroitem = Item_Factura_NroItem from FOUR_SIZONS.Item_Factura where Factura_Nro = @facnro
		set @nroitem = @nroitem + 1
		insert into FOUR_SIZONS.Item_Factura values (@facnro, @nroitem, @cant, @monto)
	end
	else
	begin
		insert into FOUR_SIZONS.Item_Factura values (@facnro, @nroitemn, @cant, @monto)
	end

end