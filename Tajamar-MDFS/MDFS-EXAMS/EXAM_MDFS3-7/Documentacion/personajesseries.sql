CREATE TABLE PERSONAJES(
	IDPERSONAJE int NOT NULL,
	PERSONAJE nvarchar(60) NULL,
	IMAGEN nvarchar(250) NULL,
	IDSERIE int NULL)
GO
ALTER TABLE PERSONAJES
ADD CONSTRAINT PK_PERSONAJES
PRIMARY KEY (IDPERSONAJE)
GO
CREATE TABLE SERIES(
	IDSERIE int NOT NULL,
	SERIE nvarchar(160) NULL,
	IMAGEN nvarchar(250) NULL,
	PUNTUACION float NULL,
	AÑO int NULL)
GO
ALTER TABLE SERIES
ADD CONSTRAINT PK_SERIES
PRIMARY KEY (IDSERIE)
GO
CREATE TABLE USUARIOSAZURE(
	IDUSUARIO int NOT NULL,
	NOMBRE nvarchar(50) NULL,
	APELLIDOS nvarchar(50) NULL,
	EMAIL nvarchar(50) NULL,
	PASS nvarchar(50) NULL)
GO
ALTER TABLE USUARIOSAZURE
ADD CONSTRAINT PK_USUARIOSAZURE
PRIMARY KEY (IDUSUARIO)
GO
INSERT INTO PERSONAJES (IDPERSONAJE, PERSONAJE, IMAGEN, IDSERIE) VALUES (1, N'Koothrappali', N'https://i.pinimg.com/originals/cd/ec/06/cdec069e361d3e41b0259fe6991e48a2.png', 6)
INSERT INTO PERSONAJES (IDPERSONAJE, PERSONAJE, IMAGEN, IDSERIE) VALUES (2, N'Barney Stinson', N'https://i.pinimg.com/originals/b9/e2/b3/b9e2b367ec3cdd3db683803f36e40b64.jpg', 4)
INSERT INTO PERSONAJES (IDPERSONAJE, PERSONAJE, IMAGEN, IDSERIE) VALUES (3, N'Dustin Henderson', N'https://spoilertime.com/wp-content/uploads/2019/05/Gaten-Matarazzo-in-Stranger-Things-2016-780x1155.jpg', 3)
INSERT INTO PERSONAJES (IDPERSONAJE, PERSONAJE, IMAGEN, IDSERIE) VALUES (4, N'Oliver Atom', N'https://i.pinimg.com/originals/d6/da/4a/d6da4a6d4a2bc7029845abb5a59f702b.jpg', 7)
INSERT INTO PERSONAJES (IDPERSONAJE, PERSONAJE, IMAGEN, IDSERIE) VALUES (5, N'Benji Price', N'https://media.revistagq.com/photos/5e7212ac9da1570008d603e5/16:9/w_1920,c_limit/benji-price-campeones-serie.jpg', 7)
INSERT INTO PERSONAJES (IDPERSONAJE, PERSONAJE, IMAGEN, IDSERIE) VALUES (6, N'Once', N'https://vader.news/__export/1598037970333/sites/gadgets/img/2020/08/21/once.jpg_691115875.jpg', 3)
INSERT INTO PERSONAJES (IDPERSONAJE, PERSONAJE, IMAGEN, IDSERIE) VALUES (7, N'Sheldon Cooper', N'https://www.bolsamania.com/cine/wp-content/uploads/2015/04/26.jpg', 6)
INSERT INTO PERSONAJES (IDPERSONAJE, PERSONAJE, IMAGEN, IDSERIE) VALUES (8, N'Ted Mosby', N'https://la.sonychannel.com/sites/la.set/files/ct_custom_page_f_primary_image/ted_portada.jpg', 8)
INSERT INTO PERSONAJES (IDPERSONAJE, PERSONAJE, IMAGEN, IDSERIE) VALUES (9, N'El Mandaloriano', N'https://static.wikia.nocookie.net/esstarwars/images/8/8a/Pascal_as_The_Mando-Advanced_Graphics.png', 2)
INSERT INTO PERSONAJES (IDPERSONAJE, PERSONAJE, IMAGEN, IDSERIE) VALUES (10, N'Baby Yoda', N'https://static2.abc.es/media/play/2020/11/13/baby-yoda-kdIH--620x349@abc.jpg', 2)
INSERT INTO PERSONAJES (IDPERSONAJE, PERSONAJE, IMAGEN, IDSERIE) VALUES (11, N'Howard Wolowitz', N'https://www.periodicodigitalgratis.com/gratis/imagen/736_20160416040412.jpg', 6)
INSERT INTO PERSONAJES (IDPERSONAJE, PERSONAJE, IMAGEN, IDSERIE) VALUES (12, N'Daenerys Targaryen', N'https://assets.afcdn.com/story/20150813/736968_w980h638c1cx494cy293.jpg', 1)
INSERT INTO PERSONAJES (IDPERSONAJE, PERSONAJE, IMAGEN, IDSERIE) VALUES (14, N'Tyrion Lannister', N'https://vader.news/__export/1593841129501/sites/gadgets/img/2020/07/04/tyrion_lannister_game_of_thrones.jpg_1255757245.jpg', 1)
INSERT INTO PERSONAJES (IDPERSONAJE, PERSONAJE, IMAGEN, IDSERIE) VALUES (15, N'Pablo Escobar', N'https://api.time.com/wp-content/uploads/2016/09/narcos_season_2.jpg', 4)
INSERT INTO PERSONAJES (IDPERSONAJE, PERSONAJE, IMAGEN, IDSERIE) VALUES (17, N'Agente Peña', N'https://cadenaser00.epimg.net/ser/imagenes/2017/09/28/television/1506579243_820899_1506581069_noticia_normal.jpg', 4)
INSERT INTO PERSONAJES (IDPERSONAJE, PERSONAJE, IMAGEN, IDSERIE) VALUES (18, N'Patriota', N'https://hipertextual.com/files/2020/09/hipertextual-2020569181.jpg', 5)
INSERT INTO PERSONAJES (IDPERSONAJE, PERSONAJE, IMAGEN, IDSERIE) VALUES (19, N'Luz Estelar', N'https://www.quever.news/u/fotografias/m/2020/9/4/f638x638-964_59131_5333.jpg', 5)
INSERT INTO PERSONAJES (IDPERSONAJE, PERSONAJE, IMAGEN, IDSERIE) VALUES (20, N'Tokio', N'https://images.clarin.com/2017/12/20/SyJOzIdzG_1256x620.jpg', 9)
INSERT INTO PERSONAJES (IDPERSONAJE, PERSONAJE, IMAGEN, IDSERIE) VALUES (21, N'Berlin', N'https://imagenes.milenio.com/Abv1Q6uPaHtF41DDvdnbqwXU8Hk=/958x596/smart/https://www.milenio.com/uploads/media/2020/05/28/creador-serie-revela-tuvieron-matar_0_150_458_285.png', 9)
INSERT INTO PERSONAJES (IDPERSONAJE, PERSONAJE, IMAGEN, IDSERIE) VALUES (22, N'Penny', N'https://hips.hearstapps.com/es.h-cdn.co/fotoes/images/noticias-cine/the-big-bang-theory-y-el-secreto-del-apellido-de-penny/109791953-1-esl-ES/The-Big-Bang-Theory-y-el-secreto-del-apellido-de-Penny.jpg', 6)
INSERT INTO PERSONAJES (IDPERSONAJE, PERSONAJE, IMAGEN, IDSERIE) VALUES (23, N'Robin Scherbatsky', N'https://i.pinimg.com/originals/00/29/68/0029683aad5d3c861b621dc1036113af.png', 8)
INSERT INTO PERSONAJES (IDPERSONAJE, PERSONAJE, IMAGEN, IDSERIE) VALUES (24, N'Ada Thorne', N'https://i.pinimg.com/originals/18/c0/25/18c02539aee1425c62972d0aa98f2e13.jpg', 2)
INSERT INTO PERSONAJES (IDPERSONAJE, PERSONAJE, IMAGEN, IDSERIE) VALUES (25, N'Lucia', N'https://i.pinimg.com/originals/8f/65/1a/8f651a6ec72dd4528e1f6a948b323558.jpg', 2)
INSERT INTO PERSONAJES (IDPERSONAJE, PERSONAJE, IMAGEN, IDSERIE) VALUES (26, N'aaa', N'https://www.infobae.com/new-resizer/OqESAKmJLemcmmfnJuS4w9AuMTE=/1200x900/filters:format(jpg):quality(85)//s3.amazonaws.com/arc-wordpress-client-uploads/infobae-wp/wp-content/uploads/2016/06/20144634/chavo1.jpg', 2)
INSERT INTO PERSONAJES (IDPERSONAJE, PERSONAJE, IMAGEN, IDSERIE) VALUES (27, N'REACT', N'https://www.infobae.com/new-resizer/OqESAKmJLemcmmfnJuS4w9AuMTE=/1200x900/filters:format(jpg):quality(85)//s3.amazonaws.com/arc-wordpress-client-uploads/infobae-wp/wp-content/uploads/2016/06/20144634/chavo1.jpg', 3)
INSERT INTO PERSONAJES (IDPERSONAJE, PERSONAJE, IMAGEN, IDSERIE) VALUES (28, N'Sonny Crokett', N'C:\fakepath\5.jpg', 2)
INSERT INTO PERSONAJES (IDPERSONAJE, PERSONAJE, IMAGEN, IDSERIE) VALUES (29, N'Sonny', N'https://images-na.ssl-images-amazon.com/images/I/41n3ccU6aML._AC_.jpg', 3)
INSERT INTO PERSONAJES (IDPERSONAJE, PERSONAJE, IMAGEN, IDSERIE) VALUES (30, N'YOYO', N'https://www.ecestaticos.com/image/clipping/197877ded7f8697b4ed50937c073ac2b/los-soprano-diez-anos-despues-del-fundido-en-negro-mas-famoso-de-la-historia.jpg', 2)
INSERT INTO PERSONAJES (IDPERSONAJE, PERSONAJE, IMAGEN, IDSERIE) VALUES (31, N'REACT JUEVES', N'https://www.ecartelera.com/images/sets/44900/44983.jpg', 3)
INSERT INTO PERSONAJES (IDPERSONAJE, PERSONAJE, IMAGEN, IDSERIE) VALUES (32, N'Jim Hooper', N'https://static.wikia.nocookie.net/strangerthings/images/2/2f/Jim_Hopper_Season_3.jpg', 3)
INSERT INTO PERSONAJES (IDPERSONAJE, PERSONAJE, IMAGEN, IDSERIE) VALUES (33, N'Steve Harrington', N'https://s1.r29static.com/bin/entry/a48/x,80/2215864/image.jpg', 3)
INSERT INTO SERIES (IDSERIE, SERIE, IMAGEN, PUNTUACION, AÑO) VALUES (1, N'Juego de tronos', N'https://cadenaser00.epimg.net/ser/imagenes/2019/05/23/television/1558591913_020782_1558595107_noticia_normal.jpg', 9.3, 2011)
INSERT INTO SERIES (IDSERIE, SERIE, IMAGEN, PUNTUACION, AÑO) VALUES (2, N'The Mandalorian', N'https://cnet1.cbsistatic.com/img/aTFHkUWhY0jK0ekKstyAfMd10xI=/940x0/2020/07/02/1a2c7d33-e1c4-4e31-b128-aff87dee41f6/art-of-mandalorian-final-cover-credits.jpg', 8.9, 2019)
INSERT INTO SERIES (IDSERIE, SERIE, IMAGEN, PUNTUACION, AÑO) VALUES (3, N'Stranger Things', N'https://e.rpp-noticias.io/xlarge/2020/02/14/145014_901131.png', 8.8, 2016)
INSERT INTO SERIES (IDSERIE, SERIE, IMAGEN, PUNTUACION, AÑO) VALUES (4, N'Narcos', N'https://www.sdpnoticias.com/files/content_image/uploads/2019/08/07/5d4ab931aba2c.jpeg', 8.8, 2015)
INSERT INTO SERIES (IDSERIE, SERIE, IMAGEN, PUNTUACION, AÑO) VALUES (5, N'The Boys', N'https://p3c8r6f2.rocketcdn.me/web/wp-content/uploads/2020/01/The-Boys-portada-1280x640.jpg', 8.7, 2019)
INSERT INTO SERIES (IDSERIE, SERIE, IMAGEN, PUNTUACION, AÑO) VALUES (6, N'The Big Bang Theory', N'https://www.camaracivica.com/wp-content/uploads/2016/12/The-Big-Bang-Theory.jpg', 8.1, 2007)
INSERT INTO SERIES (IDSERIE, SERIE, IMAGEN, PUNTUACION, AÑO) VALUES (7, N'Campeones', N'https://www.dibujos-animados.net/wp-content/uploads/2016/11/serie-oliver-benji-campeones.jpg', 8, 1983)
INSERT INTO SERIES (IDSERIE, SERIE, IMAGEN, PUNTUACION, AÑO) VALUES (8, N'Como conocí a vuestra madre', N'https://www.giztele.com/wp-content/uploads/2020/07/como-conoci-a-vuestra-madre.png', 8.3, 2005)
INSERT INTO SERIES (IDSERIE, SERIE, IMAGEN, PUNTUACION, AÑO) VALUES (9, N'La casa de papel', N'https://s1.eestatic.com/2019/07/23/cultura/series/Netflix-Series-Ursula_Corbero-Series_415970383_130773402_1024x576.jpg', 8.4, 2017)
INSERT INTO USUARIOSAZURE (IdUsuario, Nombre, Apellidos, Email, Pass) VALUES (1, N'PERRY', N'PERRY', N'perry@perry.com', N'PERRY')
INSERT INTO USUARIOSAZURE (IdUsuario, Nombre, Apellidos, Email, Pass) VALUES (2, N'ALUMNO', N'ALUMNO', N'alumno@alumno.com', N'ALUMNO')
INSERT INTO USUARIOSAZURE (IdUsuario, Nombre, Apellidos, Email, Pass) VALUES (3, N'AZURE', N'AZURE', N'azure@azure.com', N'AZURE')
