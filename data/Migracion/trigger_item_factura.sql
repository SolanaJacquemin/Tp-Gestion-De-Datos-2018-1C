alter trigger FOUR_SIZONS.corrigeItemFactura on FOUR_SIZONS.Item_Factura instead of insert
as
begin
	create table #item(
		Nro numeric(18),
		NroItem numeric(18),
		Cant numeric(18),
		Descripcion nvarchar(50),
		Monto decimal(18,2)
	)

	insert into #item
	select * from inserted i order by i.Factura_Nro, i.Item_Factura_NroItem

	declare c1 cursor for 
	select it.Nro, it.NroItem, it.Cant, it.Descripcion, it.Monto from #item it

	declare @factura numeric(18)
	declare @nro_item numeric(18)
	declare @cant numeric(18)
	declare @descr nvarchar(50)
	declare @monto decimal(18,2)

	declare @factura_ant numeric(18)
	declare @item_factura decimal(18)
	set @item_factura = 0

	open c1
	fetch next from c1 into @factura, @nro_item, @cant, @descr, @monto

	set @factura_ant = @factura

	while @@FETCH_STATUS = 0
	begin
		if(@factura = @factura_ant)
		begin
			set @item_factura = @item_factura + 1
			insert into FOUR_SIZONS.Item_Factura values (@factura, @item_factura, @cant, @descr, @monto)
		end
		else
		begin
			set @item_factura = 1
			insert into FOUR_SIZONS.Item_Factura values (@factura, @item_factura, @cant, @descr, @monto)
			set @factura_ant = @factura
		end
		fetch next from c1 into @factura, @nro_item, @cant, @descr, @monto
	end

	close c1
	deallocate c1

end