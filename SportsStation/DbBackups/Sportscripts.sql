INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'a8add6ad-11c1-4b05-94e1-2029391c93b6', N'power', N'power', N'9c363614-798a-4da1-97f8-5f11ef4953e1')
GO
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'2fca3a10-7358-4b1d-87aa-53bcc6d445db', N'Jassmanak@live.com', N'JASSMANAK@LIVE.COM', N'Jassmanak@live.com', N'JASSMANAK@LIVE.COM', 1, N'AQAAAAEAACcQAAAAENdhzSEQMdyQbFaenafCZG5ilB318O5ukGBlU9w1N1pTzrGY4vZcJ4ZSty1GBur7Yw==', N'ZFXZ5RZPLYCYVLU3GEOP7MJ5CH3VBDYW', N'5e7d9f68-1a74-435e-b022-ad569e3600aa', NULL, 0, 0, NULL, 1, 0)
GO
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'b92dfb52-ffc5-43d4-80a3-8aa033371049', N'login@sportsstation.com', N'LOGIN@SPORTSSTATION.COM', N'login@sportsstation.com', N'LOGIN@SPORTSSTATION.COM', 1, N'AQAAAAEAACcQAAAAELem89iiwuw9Hez5eFpeWG+S1rzooMVpTV9Ky+OWvYrXLdzsJlUyRTuJMGv4IN8tmA==', N'47IAKDHZF7KG4KLAW6ZZDDFP45O72OKJ', N'ee34851b-de94-4ab5-bda5-0fa703766d7d', NULL, 0, 0, NULL, 1, 0)
GO
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'aebf0494-e042-4435-b628-25e812d35353', N'a8add6ad-11c1-4b05-94e1-2029391c93b6')
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

GO
SET IDENTITY_INSERT [dbo].[SportsOrders] ON 

INSERT [dbo].[SportsOrders] ([OrderID], [Detail], [OrderDate], [UserID], [Quantity], [Price], [Total], [SportsID]) VALUES (1, N'need for school', CAST(N'2021-05-07T17:30:59.5064750' AS DateTime2), N'Jassmanak@live.com', 20, 29, 580, 1)
SET IDENTITY_INSERT [dbo].[SportsOrders] OFF
GO
ALTER TABLE [dbo].[SportsOrders]  WITH CHECK ADD  CONSTRAINT [FK_SportsOrders_SportsMaterials_SportsID] FOREIGN KEY([SportsID])
REFERENCES [dbo].[SportsMaterials] ([SportsID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[SportsOrders] CHECK CONSTRAINT [FK_SportsOrders_SportsMaterials_SportsID]
GO
