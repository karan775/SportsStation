GO
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'070f7760-7d30-4f57-9f70-d99387334c20', N'4504031b-b1a7-457a-baa5-5f58a2e8c647')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'5109aac9-941f-4fff-8fb3-c1d19c2816c3', N'4504031b-b1a7-457a-baa5-5f58a2e8c647')
GO
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'070f7760-7d30-4f57-9f70-d99387334c20', N'login1@sportsstation.com', N'LOGIN1@SPORTSSTATION.COM', N'login1@sportsstation.com', N'LOGIN1@SPORTSSTATION.COM', 1, N'AQAAAAEAACcQAAAAEMn11B2qAfanZ1Sr2s/o0WG7snYUTZH1ve/Isb3muU/N8aO43NtPO1pGsvNFgnsMFg==', N'CVGWA7AS7UEBQEEA67GS2JDSPOKVQ2MU', N'd713d402-4469-4e1e-b9ab-a3ba6cd37b47', NULL, 0, 0, NULL, 1, 0)
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'1eae2fbb-a221-453b-a89b-7b8c42553f83', N'Jassmanak@live.com', N'JASSMANAK@LIVE.COM', N'Jassmanak@live.com', N'JASSMANAK@LIVE.COM', 1, N'AQAAAAEAACcQAAAAEMfOR/NfAXqBvixRCE9Az/JoEGJT5j3oLJKxqgQCLRqi2wKs8SSbNt48dJaPGeiVBw==', N'WARWXDFYTOQUISBY2CVAGFZBHSNOJIB4', N'1d53ceb8-fa63-4646-b090-f8018a9a6877', NULL, 0, 0, NULL, 1, 0)
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'5109aac9-941f-4fff-8fb3-c1d19c2816c3', N'login@sportsstation.com', N'LOGIN@SPORTSSTATION.COM', N'login@sportsstation.com', N'LOGIN@SPORTSSTATION.COM', 0, N'AQAAAAEAACcQAAAAEK/enkZSH1SRn1+Mbrk3lH2rpj6m6JYtlWMGOnmrcGBnlmdfi3TvLo8dOPbcAdPMew==', N'YW6QFATJESAKGR56JDVWQNLVIUALRGES', N'af9766f1-61bd-48e1-b76e-029bbabb9181', NULL, 0, 0, NULL, 1, 0)
GO
SET IDENTITY_INSERT [dbo].[SportsBrands] ON 
GO
INSERT [dbo].[SportsBrands] ([SportsBrandID], [SportsBrandName]) VALUES (1, N'COSCO')
GO
INSERT [dbo].[SportsBrands] ([SportsBrandID], [SportsBrandName]) VALUES (2, N'NIVIA')
GO
INSERT [dbo].[SportsBrands] ([SportsBrandID], [SportsBrandName]) VALUES (3, N'CEAT')
GO
INSERT [dbo].[SportsBrands] ([SportsBrandID], [SportsBrandName]) VALUES (4, N'Proactive')
GO
INSERT [dbo].[SportsBrands] ([SportsBrandID], [SportsBrandName]) VALUES (5, N'MRF')
GO
INSERT [dbo].[SportsBrands] ([SportsBrandID], [SportsBrandName]) VALUES (6, N'Adrenex')
GO
INSERT [dbo].[SportsBrands] ([SportsBrandID], [SportsBrandName]) VALUES (7, N'Alfa')
GO
SET IDENTITY_INSERT [dbo].[SportsBrands] OFF
GO
SET IDENTITY_INSERT [dbo].[SportsCategories] ON 
GO
INSERT [dbo].[SportsCategories] ([SportsCategoryID], [SportsCategoryName]) VALUES (1, N'Cricket Game')
GO
INSERT [dbo].[SportsCategories] ([SportsCategoryID], [SportsCategoryName]) VALUES (2, N'Tennis Game')
GO
INSERT [dbo].[SportsCategories] ([SportsCategoryID], [SportsCategoryName]) VALUES (3, N'BasketBall Game')
GO
INSERT [dbo].[SportsCategories] ([SportsCategoryID], [SportsCategoryName]) VALUES (4, N'FootBall Game')
GO
INSERT [dbo].[SportsCategories] ([SportsCategoryID], [SportsCategoryName]) VALUES (5, N'Hockey Game')
GO
SET IDENTITY_INSERT [dbo].[SportsCategories] OFF
GO
SET IDENTITY_INSERT [dbo].[SportsMaterials] ON 
GO
INSERT [dbo].[SportsMaterials] ([SportsID], [ProductName], [Detail], [Extension], [Price], [SportsBrandID], [SportsCategoryID]) VALUES (1, N'CEAT Hitman Full Size Double Blade Poplar Cricket Bat', N'CEAT Hitman Full Size Double Blade Poplar Cricket Bat - Advance Play Poplar Willow Cricket Bat  (1.2 kg), Age Group 15+ Yrs,
Blade Made of Poplar Willow,
Advanced, Training Playing Level', N'.png', 29, 3, 1)
GO
INSERT [dbo].[SportsMaterials] ([SportsID], [ProductName], [Detail], [Extension], [Price], [SportsBrandID], [SportsCategoryID]) VALUES (2, N'MRF ENDORSED Bat', N'MRF ENDORSED | for Light/Hard Tennis Ball [with Cover] | Full Size (SH) Natural Poplar Willow Cricket Bat  (1000-1200 g)', N'.png', 32, 5, 1)
GO
INSERT [dbo].[SportsMaterials] ([SportsID], [ProductName], [Detail], [Extension], [Price], [SportsBrandID], [SportsCategoryID]) VALUES (3, N'NIVIA Engraver Basketball', N'NIVIA Engraver Basketball - Size: 6  (Pack of 1, Brown), Suitable for: Wooden Flooring & Indoor Synthetic Surface, Hard Surface', N'.png', 30, 2, 3)
GO
INSERT [dbo].[SportsMaterials] ([SportsID], [ProductName], [Detail], [Extension], [Price], [SportsBrandID], [SportsCategoryID]) VALUES (4, N'NIVIA Pro Street Basketball', N'NIVIA Pro Street Basketball - Size: 7  (Pack of 1, Black), Water Resistant,
Outer Material: Rubber', N'.png', 36, 3, 5)
GO
INSERT [dbo].[SportsMaterials] ([SportsID], [ProductName], [Detail], [Extension], [Price], [SportsBrandID], [SportsCategoryID]) VALUES (5, N'COSCO Tennis Ball (Pack of 6)', N'Being lightweight, this cosco cricket ball is easy and comfortable to hold in your hands while playing', N'.png', 18, 1, 2)
GO
INSERT [dbo].[SportsMaterials] ([SportsID], [ProductName], [Detail], [Extension], [Price], [SportsBrandID], [SportsCategoryID]) VALUES (6, N'COSCO MAX POWER Tennis Racquet', N'COSCO MAX POWER Multicolor Strung Tennis Racquet  (Pack of: 2, 350 g), This indicates that the tennis racquet is long lasting and will stay with you for a very long time.', N'.png', 49, 1, 2)
GO
INSERT [dbo].[SportsMaterials] ([SportsID], [ProductName], [Detail], [Extension], [Price], [SportsBrandID], [SportsCategoryID]) VALUES (7, N'Wooden Stumps', N'Proactive SPORTS 6 Wooden Stumps & 4 Bails (2 Wicket Set)  (Brown)', N'.png', 159, 4, 1)
GO
INSERT [dbo].[SportsMaterials] ([SportsID], [ProductName], [Detail], [Extension], [Price], [SportsBrandID], [SportsCategoryID]) VALUES (8, N'White Cricket Leather ball', N'The Adrenex Maestro 4 Panel Int Cricket Ball is made from premium tanned leather cover and has high pronounced, hand-stitched seam giving it an ideal grip. With even bounce, this four-panel ball is ideal for club cricket.', N'.png', 9, 6, 1)
GO
INSERT [dbo].[SportsMaterials] ([SportsID], [ProductName], [Detail], [Extension], [Price], [SportsBrandID], [SportsCategoryID]) VALUES (9, N'Red Cricket Leather ball', N'The Adrenex Maestro 4 Panel Int Cricket Ball is made from premium tanned leather cover and has high pronounced, hand-stitched seam giving it an ideal grip. With even bounce, this four-panel ball is ideal for club cricket.', N'.png', 11, 6, 1)
GO
INSERT [dbo].[SportsMaterials] ([SportsID], [ProductName], [Detail], [Extension], [Price], [SportsBrandID], [SportsCategoryID]) VALUES (10, N'COMPOSITE Hockey Stick', N'ALFA AX2 COMPOSITE Hockey Stick - 37 inch, DUAL CORE PREFORMING TECHNOLOGY HYBRID COMPOSITE STRUCTURE CARBON 20% KEVLAR 10% GLASS FIBRE 70% WITH PU GRIP.', N'.png', 36.30, 7, 5)
GO
INSERT [dbo].[SportsMaterials] ([SportsID], [ProductName], [Detail], [Extension], [Price], [SportsBrandID], [SportsCategoryID]) VALUES (11, N'ALFA Y30 LIMITED EDITION Hockey Stick', N'ALFA Y30 LIMITED EDITION COMPOSITE (PB) Hockey Stick - 37 inch  (Pink, Black), 10% CARBON, 10% KEVLAR, 80% GLASS FIBRE', N'.png', 34.12, 7, 5)
GO
INSERT [dbo].[SportsMaterials] ([SportsID], [ProductName], [Detail], [Extension], [Price], [SportsBrandID], [SportsCategoryID]) VALUES (12, N'Football - Size: 5 ', N'Playing a sport like football helps the players strengthen team spirit and the same time keeps them fit. This Nivia Storm Football - 5 allows you to play a few matches with friends or colleagues when you have free time.', N'.png', 8.12, 2, 4)
GO
INSERT [dbo].[SportsMaterials] ([SportsID], [ProductName], [Detail], [Extension], [Price], [SportsBrandID], [SportsCategoryID]) VALUES (13, N'NIVIA Storm Football - Size: 5 ', N'Ideal for Senior

This size 5 football is suitable for senior level players who play a more challenging game.', N'.png', 7.50, 2, 4)
GO
SET IDENTITY_INSERT [dbo].[SportsMaterials] OFF
GO

