using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace project.api.Migrations
{
    public partial class @new : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categaory",
                columns: table => new
                {
                    ID_Category = table.Column<Guid>(nullable: false),
                    Category_Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categaory", x => x.ID_Category);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    ID_User = table.Column<Guid>(nullable: false),
                    User_Name = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Password = table.Column<string>(nullable: false),
                    Confirmed_Email = table.Column<int>(nullable: false),
                    Phone = table.Column<string>(nullable: false),
                    Confirmed_Phone = table.Column<Guid>(nullable: false),
                    Gender = table.Column<string>(nullable: false),
                    Date_Created = table.Column<DateTime>(nullable: false),
                    Birth_date = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.ID_User);
                });

            migrationBuilder.CreateTable(
                name: "catgusers",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    ID_User = table.Column<Guid>(nullable: false),
                    ID_Category = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_catgusers", x => x.ID);
                    table.ForeignKey(
                        name: "FK_catgusers_Categaory_ID_Category",
                        column: x => x.ID_Category,
                        principalTable: "Categaory",
                        principalColumn: "ID_Category",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_catgusers_User_ID_User",
                        column: x => x.ID_User,
                        principalTable: "User",
                        principalColumn: "ID_User",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Post",
                columns: table => new
                {
                    ID_Post = table.Column<Guid>(nullable: false),
                    Post_Content = table.Column<string>(nullable: true),
                    Likes = table.Column<int>(nullable: false),
                    Data_Created = table.Column<DateTime>(nullable: false),
                    userID_User = table.Column<Guid>(nullable: true),
                    ID_User = table.Column<Guid>(nullable: false),
                    ID_Category = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Post", x => x.ID_Post);
                    table.ForeignKey(
                        name: "FK_Post_Categaory_ID_Category",
                        column: x => x.ID_Category,
                        principalTable: "Categaory",
                        principalColumn: "ID_Category",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Post_User_userID_User",
                        column: x => x.userID_User,
                        principalTable: "User",
                        principalColumn: "ID_User",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Reply",
                columns: table => new
                {
                    ID_Reply = table.Column<Guid>(nullable: false),
                    Content_Reply = table.Column<string>(nullable: true),
                    Likes = table.Column<int>(nullable: false),
                    Created_reply = table.Column<DateTime>(nullable: false),
                    postsID_Post = table.Column<Guid>(nullable: true),
                    CategoryID_Category = table.Column<Guid>(nullable: true),
                    UserID_User = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reply", x => x.ID_Reply);
                    table.ForeignKey(
                        name: "FK_Reply_Categaory_CategoryID_Category",
                        column: x => x.CategoryID_Category,
                        principalTable: "Categaory",
                        principalColumn: "ID_Category",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Reply_User_UserID_User",
                        column: x => x.UserID_User,
                        principalTable: "User",
                        principalColumn: "ID_User",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Reply_Post_postsID_Post",
                        column: x => x.postsID_Post,
                        principalTable: "Post",
                        principalColumn: "ID_Post",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_catgusers_ID_Category",
                table: "catgusers",
                column: "ID_Category");

            migrationBuilder.CreateIndex(
                name: "IX_catgusers_ID_User",
                table: "catgusers",
                column: "ID_User");

            migrationBuilder.CreateIndex(
                name: "IX_Post_ID_Category",
                table: "Post",
                column: "ID_Category");

            migrationBuilder.CreateIndex(
                name: "IX_Post_userID_User",
                table: "Post",
                column: "userID_User");

            migrationBuilder.CreateIndex(
                name: "IX_Reply_CategoryID_Category",
                table: "Reply",
                column: "CategoryID_Category");

            migrationBuilder.CreateIndex(
                name: "IX_Reply_UserID_User",
                table: "Reply",
                column: "UserID_User");

            migrationBuilder.CreateIndex(
                name: "IX_Reply_postsID_Post",
                table: "Reply",
                column: "postsID_Post");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "catgusers");

            migrationBuilder.DropTable(
                name: "Reply");

            migrationBuilder.DropTable(
                name: "Post");

            migrationBuilder.DropTable(
                name: "Categaory");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
