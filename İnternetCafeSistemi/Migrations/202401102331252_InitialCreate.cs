namespace İnternetCafeSistemi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.sysdiagrams",
                c => new
                    {
                        principal_id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        diagram_id = c.Int(nullable: false),
                        version = c.Int(),
                        definition = c.Binary(),
                    })
                .PrimaryKey(t => t.principal_id);
            
            CreateTable(
                "dbo.TableAdminlers",
                c => new
                    {
                        AdminID = c.Int(nullable: false, identity: true),
                        KullaniciAdi = c.String(),
                        Sifre = c.String(),
                    })
                .PrimaryKey(t => t.AdminID);
            
            CreateTable(
                "dbo.TableHareketlers",
                c => new
                    {
                        HareketID = c.Int(nullable: false, identity: true),
                        KullaniciID = c.Int(),
                        MasaID = c.Int(),
                        IslemTuru = c.String(),
                        IslemZamani = c.DateTime(nullable: false),
                        TableKullanicilar_KullaniciID = c.Int(),
                        TableKullanicilar_KullaniciID1 = c.Int(),
                        TableMasalar_MasaID = c.Int(),
                        TableMasalar_MasaID1 = c.Int(),
                        TableKullanicilar_KullaniciID2 = c.Int(),
                        TableKullanicilar1_KullaniciID = c.Int(),
                        TableMasalar_MasaID2 = c.Int(),
                        TableMasalar1_MasaID = c.Int(),
                    })
                .PrimaryKey(t => t.HareketID)
                .ForeignKey("dbo.TableKullanicilars", t => t.TableKullanicilar_KullaniciID)
                .ForeignKey("dbo.TableKullanicilars", t => t.TableKullanicilar_KullaniciID1)
                .ForeignKey("dbo.TableMasalars", t => t.TableMasalar_MasaID)
                .ForeignKey("dbo.TableMasalars", t => t.TableMasalar_MasaID1)
                .ForeignKey("dbo.TableKullanicilars", t => t.TableKullanicilar_KullaniciID2)
                .ForeignKey("dbo.TableKullanicilars", t => t.TableKullanicilar1_KullaniciID)
                .ForeignKey("dbo.TableMasalars", t => t.TableMasalar_MasaID2)
                .ForeignKey("dbo.TableMasalars", t => t.TableMasalar1_MasaID)
                .Index(t => t.TableKullanicilar_KullaniciID)
                .Index(t => t.TableKullanicilar_KullaniciID1)
                .Index(t => t.TableMasalar_MasaID)
                .Index(t => t.TableMasalar_MasaID1)
                .Index(t => t.TableKullanicilar_KullaniciID2)
                .Index(t => t.TableKullanicilar1_KullaniciID)
                .Index(t => t.TableMasalar_MasaID2)
                .Index(t => t.TableMasalar1_MasaID);
            
            CreateTable(
                "dbo.TableKullanicilars",
                c => new
                    {
                        KullaniciID = c.Int(nullable: false, identity: true),
                        KullaniciAdi = c.String(),
                        Sifre = c.String(),
                        Mail = c.String(),
                        KayitTarihi = c.DateTime(nullable: false),
                        IstekDurum = c.Int(nullable: false),
                        MasaID = c.Int(),
                    })
                .PrimaryKey(t => t.KullaniciID);
            
            CreateTable(
                "dbo.TableMasalars",
                c => new
                    {
                        MasaID = c.Int(nullable: false, identity: true),
                        MasaAdi = c.String(),
                        Durumu = c.String(),
                        KullaniciID = c.Int(),
                    })
                .PrimaryKey(t => t.MasaID)
                .ForeignKey("dbo.TableKullanicilars", t => t.KullaniciID)
                .Index(t => t.KullaniciID);
            
            CreateTable(
                "dbo.TableOturumlars",
                c => new
                    {
                        OturumID = c.Int(nullable: false, identity: true),
                        KullaniciID = c.Int(),
                        MasaID = c.Int(),
                        BaslangicZamani = c.DateTime(),
                        BitisZamanı = c.DateTime(),
                        KullanilanSure = c.Int(),
                        Ucret = c.Decimal(precision: 18, scale: 2),
                        AcilisTuru = c.String(),
                    })
                .PrimaryKey(t => t.OturumID)
                .ForeignKey("dbo.TableKullanicilars", t => t.KullaniciID)
                .ForeignKey("dbo.TableMasalars", t => t.MasaID)
                .Index(t => t.KullaniciID)
                .Index(t => t.MasaID);
            
            CreateTable(
                "dbo.TableSatis",
                c => new
                    {
                        SatısID = c.Int(nullable: false, identity: true),
                        KullaniciID = c.Int(),
                        MasaID = c.Int(),
                        BaslangicZamani = c.DateTime(),
                        BitisZamani = c.DateTime(),
                        AcilisTuru = c.String(),
                        KullanilanSüre = c.Int(),
                        Ucret = c.Decimal(precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.SatısID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TableHareketlers", "TableMasalar1_MasaID", "dbo.TableMasalars");
            DropForeignKey("dbo.TableHareketlers", "TableMasalar_MasaID2", "dbo.TableMasalars");
            DropForeignKey("dbo.TableHareketlers", "TableKullanicilar1_KullaniciID", "dbo.TableKullanicilars");
            DropForeignKey("dbo.TableHareketlers", "TableKullanicilar_KullaniciID2", "dbo.TableKullanicilars");
            DropForeignKey("dbo.TableOturumlars", "MasaID", "dbo.TableMasalars");
            DropForeignKey("dbo.TableOturumlars", "KullaniciID", "dbo.TableKullanicilars");
            DropForeignKey("dbo.TableMasalars", "KullaniciID", "dbo.TableKullanicilars");
            DropForeignKey("dbo.TableHareketlers", "TableMasalar_MasaID1", "dbo.TableMasalars");
            DropForeignKey("dbo.TableHareketlers", "TableMasalar_MasaID", "dbo.TableMasalars");
            DropForeignKey("dbo.TableHareketlers", "TableKullanicilar_KullaniciID1", "dbo.TableKullanicilars");
            DropForeignKey("dbo.TableHareketlers", "TableKullanicilar_KullaniciID", "dbo.TableKullanicilars");
            DropIndex("dbo.TableOturumlars", new[] { "MasaID" });
            DropIndex("dbo.TableOturumlars", new[] { "KullaniciID" });
            DropIndex("dbo.TableMasalars", new[] { "KullaniciID" });
            DropIndex("dbo.TableHareketlers", new[] { "TableMasalar1_MasaID" });
            DropIndex("dbo.TableHareketlers", new[] { "TableMasalar_MasaID2" });
            DropIndex("dbo.TableHareketlers", new[] { "TableKullanicilar1_KullaniciID" });
            DropIndex("dbo.TableHareketlers", new[] { "TableKullanicilar_KullaniciID2" });
            DropIndex("dbo.TableHareketlers", new[] { "TableMasalar_MasaID1" });
            DropIndex("dbo.TableHareketlers", new[] { "TableMasalar_MasaID" });
            DropIndex("dbo.TableHareketlers", new[] { "TableKullanicilar_KullaniciID1" });
            DropIndex("dbo.TableHareketlers", new[] { "TableKullanicilar_KullaniciID" });
            DropTable("dbo.TableSatis");
            DropTable("dbo.TableOturumlars");
            DropTable("dbo.TableMasalars");
            DropTable("dbo.TableKullanicilars");
            DropTable("dbo.TableHareketlers");
            DropTable("dbo.TableAdminlers");
            DropTable("dbo.sysdiagrams");
        }
    }
}
