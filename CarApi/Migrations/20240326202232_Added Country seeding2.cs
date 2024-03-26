using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarApi.Migrations
{
    /// <inheritdoc />
    public partial class AddedCountryseeding2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "IdCountry", "CountryCode", "CreatedAt", "Flag", "ModifiedAt", "Name" },
                values: new object[,]
                {
                    { 1, "AF", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(359), "https://flagcdn.com/af.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(361), "Afganistán" },
                    { 2, "AL", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(365), "https://flagcdn.com/al.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(365), "Albania" },
                    { 3, "DE", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(366), "https://flagcdn.com/de.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(367), "Alemania" },
                    { 4, "AD", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(368), "https://flagcdn.com/ad.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(368), "Andorra" },
                    { 5, "AO", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(401), "https://flagcdn.com/ao.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(402), "Angola" },
                    { 6, "AG", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(404), "https://flagcdn.com/ag.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(405), "Antigua y Barbuda" },
                    { 7, "SA", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(406), "https://flagcdn.com/sa.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(406), "Arabia Saudita" },
                    { 8, "DZ", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(407), "https://flagcdn.com/dz.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(407), "Argelia" },
                    { 9, "AR", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(408), "https://flagcdn.com/ar.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(408), "Argentina" },
                    { 10, "AM", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(410), "https://flagcdn.com/am.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(410), "Armenia" },
                    { 11, "AU", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(411), "https://flagcdn.com/au.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(411), "Australia" },
                    { 12, "AT", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(412), "https://flagcdn.com/at.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(412), "Austria" },
                    { 13, "AZ", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(413), "https://flagcdn.com/az.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(413), "Azerbaiyán" },
                    { 14, "BS", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(413), "https://flagcdn.com/bs.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(414), "Bahamas" },
                    { 15, "BD", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(414), "https://flagcdn.com/bd.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(415), "Bangladés" },
                    { 16, "BB", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(415), "https://flagcdn.com/bb.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(415), "Barbados" },
                    { 17, "BH", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(416), "https://flagcdn.com/bh.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(416), "Baréin" },
                    { 18, "BE", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(418), "https://flagcdn.com/be.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(418), "Bélgica" },
                    { 19, "BZ", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(418), "https://flagcdn.com/bz.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(419), "Belice" },
                    { 20, "BJ", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(419), "https://flagcdn.com/bj.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(420), "Benín" },
                    { 21, "BY", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(420), "https://flagcdn.com/by.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(420), "Bielorrusia" },
                    { 22, "MM", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(421), "https://flagcdn.com/mm.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(421), "Birmania" },
                    { 23, "BO", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(422), "https://flagcdn.com/bo.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(422), "Bolivia" },
                    { 24, "BA", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(423), "https://flagcdn.com/ba.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(423), "Bosnia y Herzegovina" },
                    { 25, "BW", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(424), "https://flagcdn.com/bw.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(424), "Botsuana" },
                    { 26, "BR", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(425), "https://flagcdn.com/br.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(425), "Brasil" },
                    { 27, "BN", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(426), "https://flagcdn.com/bn.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(426), "Brunéi" },
                    { 28, "BG", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(426), "https://flagcdn.com/bg.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(427), "Bulgaria" },
                    { 29, "BF", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(427), "https://flagcdn.com/bf.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(428), "Burkina Faso" },
                    { 30, "BI", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(428), "https://flagcdn.com/bi.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(428), "Burundi" },
                    { 31, "BT", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(429), "https://flagcdn.com/bt.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(429), "Bután" },
                    { 32, "CV", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(430), "https://flagcdn.com/cv.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(430), "Cabo Verde" },
                    { 33, "KH", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(430), "https://flagcdn.com/kh.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(431), "Camboya" },
                    { 34, "CM", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(432), "https://flagcdn.com/cm.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(432), "Camerún" },
                    { 35, "CA", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(433), "https://flagcdn.com/ca.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(433), "Canadá" },
                    { 36, "QA", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(434), "https://flagcdn.com/qa.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(434), "Catar" },
                    { 37, "TD", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(435), "https://flagcdn.com/td.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(435), "Chad" },
                    { 38, "CL", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(435), "https://flagcdn.com/cl.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(436), "Chile" },
                    { 39, "CN", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(436), "https://flagcdn.com/cn.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(436), "China" },
                    { 40, "CY", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(437), "https://flagcdn.com/cy.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(437), "Chipre" },
                    { 41, "CO", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(438), "https://flagcdn.com/co.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(438), "Colombia" },
                    { 42, "KM", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(438), "https://flagcdn.com/km.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(439), "Comoras" },
                    { 43, "CG", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(439), "https://flagcdn.com/cg.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(440), "Congo" },
                    { 44, "KP", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(440), "https://flagcdn.com/kp.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(440), "Corea del Norte" },
                    { 45, "KR", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(441), "https://flagcdn.com/kr.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(441), "Corea del Sur" },
                    { 46, "CI", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(442), "https://flagcdn.com/ci.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(442), "Costa de Marfil" },
                    { 47, "CR", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(443), "https://flagcdn.com/cr.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(443), "Costa Rica" },
                    { 48, "HR", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(443), "https://flagcdn.com/hr.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(444), "Croacia" },
                    { 49, "CU", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(444), "https://flagcdn.com/cu.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(444), "Cuba" },
                    { 50, "DK", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(445), "https://flagcdn.com/dk.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(445), "Dinamarca" },
                    { 51, "DM", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(446), "https://flagcdn.com/dm.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(446), "Dominica" },
                    { 52, "EC", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(446), "https://flagcdn.com/ec.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(447), "Ecuador" },
                    { 53, "EG", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(447), "https://flagcdn.com/eg.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(447), "Egipto" },
                    { 54, "SV", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(448), "https://flagcdn.com/sv.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(448), "El Salvador" },
                    { 55, "AE", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(449), "https://flagcdn.com/ae.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(449), "Emiratos Árabes Unidos" },
                    { 56, "ER", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(449), "https://flagcdn.com/er.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(450), "Eritrea" },
                    { 57, "SK", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(450), "https://flagcdn.com/sk.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(450), "Eslovaquia" },
                    { 58, "SI", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(451), "https://flagcdn.com/si.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(451), "Eslovenia" },
                    { 59, "ES", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(452), "https://flagcdn.com/es.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(452), "España" },
                    { 60, "US", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(452), "https://flagcdn.com/us.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(453), "Estados Unidos" },
                    { 61, "EE", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(453), "https://flagcdn.com/ee.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(454), "Estonia" },
                    { 62, "ET", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(454), "https://flagcdn.com/et.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(454), "Etiopía" },
                    { 63, "PH", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(455), "https://flagcdn.com/ph.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(455), "Filipinas" },
                    { 64, "FI", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(455), "https://flagcdn.com/fi.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(456), "Finlandia" },
                    { 65, "FJ", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(456), "https://flagcdn.com/fj.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(457), "Fiyi" },
                    { 66, "FR", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(458), "https://flagcdn.com/fr.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(458), "Francia" },
                    { 67, "GA", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(459), "https://flagcdn.com/ga.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(459), "Gabón" },
                    { 68, "GM", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(460), "https://flagcdn.com/gm.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(460), "Gambia" },
                    { 69, "GE", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(460), "https://flagcdn.com/ge.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(461), "Georgia" },
                    { 70, "GH", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(461), "https://flagcdn.com/gh.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(461), "Ghana" },
                    { 71, "GD", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(462), "https://flagcdn.com/gd.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(462), "Granada" },
                    { 72, "GR", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(463), "https://flagcdn.com/gr.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(463), "Grecia" },
                    { 73, "GT", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(463), "https://flagcdn.com/gt.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(464), "Guatemala" },
                    { 74, "GN", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(464), "https://flagcdn.com/gn.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(465), "Guinea" },
                    { 75, "GW", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(465), "https://flagcdn.com/gw.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(465), "Guinea-Bisáu" },
                    { 76, "GQ", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(466), "https://flagcdn.com/gq.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(466), "Guinea Ecuatorial" },
                    { 77, "GY", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(467), "https://flagcdn.com/gy.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(467), "Guyana" },
                    { 78, "HT", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(467), "https://flagcdn.com/ht.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(468), "Haití" },
                    { 79, "HN", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(468), "https://flagcdn.com/hn.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(468), "Honduras" },
                    { 80, "HU", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(499), "https://flagcdn.com/hu.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(501), "Hungría" },
                    { 81, "IN", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(502), "https://flagcdn.com/in.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(503), "India" },
                    { 82, "ID", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(503), "https://flagcdn.com/id.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(504), "Indonesia" },
                    { 83, "IQ", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(504), "https://flagcdn.com/iq.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(505), "Irak" },
                    { 84, "IR", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(505), "https://flagcdn.com/ir.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(506), "Irán" },
                    { 85, "IE", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(506), "https://flagcdn.com/ie.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(506), "Irlanda" },
                    { 86, "IS", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(507), "https://flagcdn.com/is.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(507), "Islandia" },
                    { 87, "MH", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(508), "https://flagcdn.com/mh.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(508), "Islas Marshall" },
                    { 88, "SB", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(508), "https://flagcdn.com/sb.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(509), "Islas Salomón" },
                    { 89, "IL", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(509), "https://flagcdn.com/il.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(509), "Israel" },
                    { 90, "IT", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(510), "https://flagcdn.com/it.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(510), "Italia" },
                    { 91, "JM", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(511), "https://flagcdn.com/jm.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(511), "Jamaica" },
                    { 92, "JP", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(511), "https://flagcdn.com/jp.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(512), "Japón" },
                    { 93, "JO", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(512), "https://flagcdn.com/jo.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(513), "Jordania" },
                    { 94, "KZ", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(513), "https://flagcdn.com/kz.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(513), "Kazajistán" },
                    { 95, "KE", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(514), "https://flagcdn.com/ke.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(514), "Kenia" },
                    { 96, "KG", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(515), "https://flagcdn.com/kg.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(515), "Kirguistán" },
                    { 97, "KI", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(515), "https://flagcdn.com/ki.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(516), "Kiribati" },
                    { 98, "KW", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(516), "https://flagcdn.com/kw.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(517), "Kuwait" },
                    { 99, "LA", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(517), "https://flagcdn.com/la.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(517), "Laos" },
                    { 100, "LS", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(518), "https://flagcdn.com/ls.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(518), "Lesoto" },
                    { 101, "LV", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(519), "https://flagcdn.com/lv.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(519), "Letonia" },
                    { 102, "LB", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(519), "https://flagcdn.com/lb.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(520), "Líbano" },
                    { 103, "LR", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(520), "https://flagcdn.com/lr.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(520), "Liberia" },
                    { 104, "LY", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(521), "https://flagcdn.com/ly.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(521), "Libia" },
                    { 105, "LI", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(522), "https://flagcdn.com/li.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(522), "Liechtenstein" },
                    { 106, "LT", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(522), "https://flagcdn.com/lt.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(523), "Lituania" },
                    { 107, "LU", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(523), "https://flagcdn.com/lu.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(524), "Luxemburgo" },
                    { 108, "MG", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(524), "https://flagcdn.com/mg.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(524), "Madagascar" },
                    { 109, "MY", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(525), "https://flagcdn.com/my.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(525), "Malasia" },
                    { 110, "MW", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(526), "https://flagcdn.com/mw.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(526), "Malaui" },
                    { 111, "MV", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(526), "https://flagcdn.com/mv.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(527), "Maldivas" },
                    { 112, "ML", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(527), "https://flagcdn.com/ml.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(527), "Malí" },
                    { 113, "MT", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(528), "https://flagcdn.com/mt.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(528), "Malta" },
                    { 114, "MA", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(529), "https://flagcdn.com/ma.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(529), "Marruecos" },
                    { 115, "MU", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(529), "https://flagcdn.com/mu.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(530), "Mauricio" },
                    { 116, "MR", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(530), "https://flagcdn.com/mr.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(531), "Mauritania" },
                    { 117, "MX", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(531), "https://flagcdn.com/mx.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(531), "México" },
                    { 118, "FM", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(532), "https://flagcdn.com/fm.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(532), "Micronesia" },
                    { 119, "MD", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(533), "https://flagcdn.com/md.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(533), "Moldavia" },
                    { 120, "MC", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(533), "https://flagcdn.com/mc.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(534), "Mónaco" },
                    { 121, "MN", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(534), "https://flagcdn.com/mn.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(534), "Mongolia" },
                    { 122, "ME", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(535), "https://flagcdn.com/me.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(535), "Montenegro" },
                    { 123, "MZ", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(536), "https://flagcdn.com/mz.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(536), "Mozambique" },
                    { 124, "NA", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(536), "https://flagcdn.com/na.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(537), "Namibia" },
                    { 125, "NR", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(537), "https://flagcdn.com/nr.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(537), "Nauru" },
                    { 126, "NP", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(538), "https://flagcdn.com/np.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(538), "Nepal" },
                    { 127, "NI", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(539), "https://flagcdn.com/ni.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(539), "Nicaragua" },
                    { 128, "NE", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(540), "https://flagcdn.com/ne.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(540), "Níger" },
                    { 129, "NG", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(540), "https://flagcdn.com/ng.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(541), "Nigeria" },
                    { 130, "NO", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(542), "https://flagcdn.com/no.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(543), "Noruega" },
                    { 131, "NZ", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(543), "https://flagcdn.com/nz.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(543), "Nueva Zelanda" },
                    { 132, "OM", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(544), "https://flagcdn.com/om.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(544), "Omán" },
                    { 133, "NL", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(545), "https://flagcdn.com/nl.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(545), "Países Bajos" },
                    { 134, "PK", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(546), "https://flagcdn.com/pk.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(546), "Pakistán" },
                    { 135, "PW", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(546), "https://flagcdn.com/pw.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(547), "Palaos" },
                    { 136, "PA", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(547), "https://flagcdn.com/pa.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(547), "Panamá" },
                    { 137, "PG", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(548), "https://flagcdn.com/pg.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(548), "Papúa Nueva Guinea" },
                    { 138, "PY", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(549), "https://flagcdn.com/py.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(549), "Paraguay" },
                    { 139, "PE", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(549), "https://flagcdn.com/pe.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(550), "Perú" },
                    { 140, "PL", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(550), "https://flagcdn.com/pl.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(551), "Polonia" },
                    { 141, "PT", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(551), "https://flagcdn.com/pt.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(551), "Portugal" },
                    { 142, "GB", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(552), "https://flagcdn.com/gb.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(552), "Reino Unido" },
                    { 143, "CF", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(553), "https://flagcdn.com/cf.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(553), "República Centroafricana" },
                    { 144, "CZ", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(553), "https://flagcdn.com/cz.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(554), "República Checa" },
                    { 145, "CD", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(554), "https://flagcdn.com/cd.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(554), "República del Congo" },
                    { 146, "DO", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(555), "https://flagcdn.com/do.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(555), "República Dominicana" },
                    { 147, "RW", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(556), "https://flagcdn.com/rw.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(556), "Ruanda" },
                    { 148, "RO", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(556), "https://flagcdn.com/ro.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(557), "Rumania" },
                    { 149, "RU", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(557), "https://flagcdn.com/ru.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(557), "Rusia" },
                    { 150, "WS", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(558), "https://flagcdn.com/ws.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(558), "Samoa" },
                    { 151, "KN", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(559), "https://flagcdn.com/kn.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(559), "San Cristóbal y Nieves" },
                    { 152, "SM", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(559), "https://flagcdn.com/sm.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(560), "San Marino" },
                    { 153, "LC", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(560), "https://flagcdn.com/lc.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(560), "Santa Lucía" },
                    { 154, "ST", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(561), "https://flagcdn.com/st.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(561), "Santo Tomé y Príncipe" },
                    { 155, "VC", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(562), "https://flagcdn.com/vc.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(562), "San Vicente y las Granadinas" },
                    { 156, "SN", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(562), "https://flagcdn.com/sn.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(563), "Senegal" },
                    { 157, "RS", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(595), "https://flagcdn.com/rs.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(597), "Serbia" },
                    { 158, "SC", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(597), "https://flagcdn.com/sc.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(598), "Seychelles" },
                    { 159, "SL", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(598), "https://flagcdn.com/sl.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(599), "Sierra Leona" },
                    { 160, "SG", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(599), "https://flagcdn.com/sg.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(600), "Singapur" },
                    { 161, "SY", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(600), "https://flagcdn.com/sy.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(601), "Siria" },
                    { 162, "SO", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(601), "https://flagcdn.com/so.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(601), "Somalia" },
                    { 163, "LK", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(602), "https://flagcdn.com/lk.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(602), "Sri Lanka" },
                    { 164, "ZA", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(603), "https://flagcdn.com/za.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(603), "Sudáfrica" },
                    { 165, "SD", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(603), "https://flagcdn.com/sd.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(604), "Sudán" },
                    { 166, "SS", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(604), "https://flagcdn.com/ss.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(605), "Sudán del Sur" },
                    { 167, "SE", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(605), "https://flagcdn.com/se.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(605), "Suecia" },
                    { 168, "CH", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(606), "https://flagcdn.com/ch.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(606), "Suiza" },
                    { 169, "SR", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(607), "https://flagcdn.com/sr.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(607), "Surinam" },
                    { 170, "TH", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(607), "https://flagcdn.com/th.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(608), "Tailandia" },
                    { 171, "TZ", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(608), "https://flagcdn.com/tz.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(608), "Tanzania" },
                    { 172, "TJ", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(609), "https://flagcdn.com/tj.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(609), "Tayikistán" },
                    { 173, "TL", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(610), "https://flagcdn.com/tl.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(610), "Timor Oriental" },
                    { 174, "TG", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(610), "https://flagcdn.com/tg.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(611), "Togo" },
                    { 175, "TO", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(611), "https://flagcdn.com/to.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(612), "Tonga" },
                    { 176, "TT", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(612), "https://flagcdn.com/tt.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(612), "Trinidad y Tobago" },
                    { 177, "TN", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(613), "https://flagcdn.com/tn.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(613), "Túnez" },
                    { 178, "TM", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(614), "https://flagcdn.com/tm.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(614), "Turkmenistán" },
                    { 179, "TR", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(614), "https://flagcdn.com/tr.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(615), "Turquía" },
                    { 180, "TV", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(615), "https://flagcdn.com/tv.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(615), "Tuvalu" },
                    { 181, "UA", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(616), "https://flagcdn.com/ua.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(616), "Ucrania" },
                    { 182, "UG", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(617), "https://flagcdn.com/ug.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(617), "Uganda" },
                    { 183, "UY", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(618), "https://flagcdn.com/uy.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(618), "Uruguay" },
                    { 184, "UZ", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(618), "https://flagcdn.com/uz.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(619), "Uzbekistán" },
                    { 185, "VU", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(619), "https://flagcdn.com/vu.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(619), "Vanuatu" },
                    { 186, "VE", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(620), "https://flagcdn.com/ve.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(620), "Venezuela" },
                    { 187, "VN", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(621), "https://flagcdn.com/vn.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(621), "Vietnam" },
                    { 188, "YE", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(621), "https://flagcdn.com/ye.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(622), "Yemen" },
                    { 189, "DJ", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(622), "https://flagcdn.com/dj.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(622), "Yibuti" },
                    { 190, "ZM", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(623), "https://flagcdn.com/zm.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(623), "Zambia" },
                    { 191, "ZW", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(624), "https://flagcdn.com/zw.svg", new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(624), "Zimbabue" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 191);
        }
    }
}
