public partial class AddOpeningHoursToPhysio : Migration
{
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.CreateTable(
            name: "OpeningHours",
            columns: table => new
            {
                Id = table.Column<int>(nullable: false)
                    .Annotation("SqlServer:Identity", "1, 1"),
                DayOfWeek = table.Column<string>(nullable: false),
                From = table.Column<string>(nullable: false),
                To = table.Column<string>(nullable: false),
                PhysioId = table.Column<int>(nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_OpeningHours", x => x.Id);
                table.ForeignKey(
                    name: "FK_OpeningHours_Physio_PhysioId",
                    column: x => x.PhysioId,
                    principalTable: "Physio",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Cascade);
            });

        migrationBuilder.CreateIndex(
            name: "IX_Physio_PhysioId",
            table: "OpeningHours",
            column: "PhysioId");
    }

    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropTable(
            name: "OpeningHours");
    }
}