using GameStore.Data.Enums;
using GameStore.Models;
using System;

namespace GameStore.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();
                context.Database.EnsureCreated();

                //Developer
                if (!context.Developer.Any())
                {
                    context.Developer.AddRange(new List<Developer>()
                    {
                        new Developer()
                        {
                            DeveloperName = "Square Enix",
                            DeveloperPicture = "https://avatars.cloudflare.steamstatic.com/2fe0615e013c887e87dd230e8268afdd15416f12_full.jpg",
                            Description = "Square Enix Holdings Co., Ltd.[b] is a Japanese multinational holding company," +
                            " video game production enterprise and entertainment conglomerate. It releases role-playing game franchises, such as Final Fantasy," +
                            " Dragon Quest, and Kingdom Hearts, among numerous others. Outside of video game publishing and development, it is also in the business of merchandise," +
                            " arcade facilities, and manga publication under its Gangan Comics brand."
                            
                        },
                        new Developer()
                        {
                            DeveloperName = "CD PROJEKT RED",
                            DeveloperPicture = "https://avatars.cloudflare.steamstatic.com/4f1187c11ad41f8aa58b9109efd52c2f8bca9918_full.jpg",
                            Description = "CD Projekt S.A. is a Polish video game developer, publisher and distributor based in Warsaw, founded in May 1994 by Marcin Iwiński and Michał Kiciński. Iwiński and Kiciński were video game retailers before they founded the company, which initially acted as a distributor of foreign video games for the domestic market. The department responsible for developing original games, CD Projekt Red (stylised as CD PROJEKT RED), best known for The Witcher series, was formed in 2002. In 2008, CD Projekt launched the digital distribution service Good Old Games, now known as GOG.com."
                            
                        },
                        new Developer()
                        {
                            DeveloperName = "Ubisoft",
                            DeveloperPicture = "https://avatars.cloudflare.steamstatic.com/2b2486ae5a70d69c55f020ce8384d04646ddba4e_full.jpg",
                            Description = "Ubisoft Entertainment SA is a French video game publisher headquartered in Saint-Mandé with development studios across the world. Its video game franchises include Assassin's Creed, Far Cry, For Honor, Just Dance, Prince of Persia, Rabbids, Rayman, Tom Clancy's, and Watch Dogs."
                            
                        },
                    });
                    context.SaveChanges();
                }
                // Publisher
                if (!context.Publisher.Any())
                {
                    context.Publisher.AddRange(new List<Publisher>()
                    {
                        new Publisher()
                        {
                            PublisherName = "CD PROJEKT RED",
                            Logo = "https://avatars.cloudflare.steamstatic.com/4f1187c11ad41f8aa58b9109efd52c2f8bca9918_full.jpg",
                            Description = "Ubisoft Entertainment SA is a French video game publisher headquartered in Saint-Mandé with development studios across the world. Its video game franchises include Assassin's Creed, Far Cry, For Honor, Just Dance, Prince of Persia, Rabbids, Rayman, Tom Clancy's, and Watch Dogs.",
                            
                        },
                        new Publisher()
                        {
                            PublisherName= "Electronic Arts",
                            Logo ="https://avatars.cloudflare.steamstatic.com/618cc2a46fad78ed1259df505c2de5bb4d806532_full.jpg",
                            Description = "Electronic Arts Inc. (EA) is an American video game company headquartered in Redwood City, California. Founded in May 1982 by Apple employee Trip Hawkins, the company was a pioneer of the early home computer game industry and promoted the designers and programmers responsible for its games as \"software artists\". EA published numerous games and some productivity software for personal computers, all of which were developed by external individuals or groups until 1987's Skate or Die!. The company shifted toward internal game studios, often through acquisitions, such as Distinctive Software becoming EA Canada in 1991.",
                            
                        },
                        new Publisher()
                        {
                            PublisherName= "Activision",
                            Logo ="https://avatars.cloudflare.steamstatic.com/751c4faad6133699315ca7d4ae03293cd3abbe49_full.jpg",
                            Description = "Activision Publishing, Inc. is an American video game publisher based in Santa Monica, California. It serves as the publishing business for its parent company, Activision Blizzard, and consists of several subsidiary studios. Activision is one of the largest third-party video game publishers in the world and was the top United States publisher in 2016.",
                            
                        },
                    }); ;
                    context.SaveChanges();
                   
                }
                //Platform
                if (!context.Platforms.Any())
                {
                    context.Platforms.AddRange(new List<Platforms>()
                  {
                            new Platforms()
                            {
                                PlatformPicture = "https://media.wired.com/photos/5ed56dac0164ade5f2950d7f/master/w_2560%2Cc_limit/Gear-Buying-Guide-HP-Omen-Desktop-SOURCE-HP.jpg",
                                PlatformName = "PC",
                                Description = "",
                                                              
                            },
                            new Platforms()
                            {
                                PlatformPicture = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQyxy7FnQgGZMXp5n4larTk6bWKNiUO7s7FZA&usqp=CAU",
                                PlatformName = "Mobile",
                                Description = "",
                                
                            },
                            new Platforms()
                            {
                                PlatformPicture = "https://avatars.cloudflare.steamstatic.com/40a85b52747a78b26e393e3f9e58f319194b1b33_full.jpg",
                                PlatformName = "PlayStation",
                                Description = "",
                                
                            },
                             new Platforms()
                            {
                                PlatformPicture = "https://avatars.cloudflare.steamstatic.com/160d7b7d4811951be05e64e821cc93698fccf310_full.jpg",
                                PlatformName = "Xbox",
                                Description = "",
                                
                            },
                    });
                    context.SaveChanges();
                }
                //Game
                if (!context.Game.Any())
                {
                    context.Game.AddRange(new List<Game>()
                    {
                        new Game()
                        {
                            NameOfTheGame = "FINAL FANTASY XIV",
                            Description = "Take part in an epic and ever-changing FINAL FANTASY as you adventure and explore with friends from around the world. This product also includes the entitlements to play FINAL FANTASY® XIV: A Realm Reborn and the expansion pack FINAL FANTASY® XIV: HEAVENSWARD.",
                            ImageURL = "https://cdn.cloudflare.steamstatic.com/steam/apps/39210/header.jpg?t=1684850999",
                            ReleaseDate = DateTime.Now.AddDays(7),
                            GameCategory= GameCategory.RPG,
                            PublisherId = 1,
                            DeveloperId = 2,
                        },
                        new Game()
                        {
                            NameOfTheGame = "The Witcher 3: Wild Hunt",
                            Description = "You are Geralt of Rivia, mercenary monster slayer. Before you stands a war-torn, monster-infested continent you can explore at will. Your current contract? Tracking down Ciri — the Child of Prophecy, a living weapon that can alter the shape of the world",
                            ImageURL = "https://cdn.cloudflare.steamstatic.com/steam/apps/292030/header.jpg?t=1687959506",
                            ReleaseDate = DateTime.Now.AddDays(-10),
                            GameCategory = GameCategory.Adventure,
                            PublisherId = 3,
                            DeveloperId = 3,
                        },

                    });

                    context.SaveChanges();
                }
                //Platforms&Games
                if (!context.Platforms_Games.Any())
                {
                    context.Platforms_Games.AddRange(new List<Platforms_Games>()
                    {
                        new Platforms_Games()
                        {
                            GameId = 2,
                            PlatformId =3 ,
                        },
                        new Platforms_Games()
                        {
                            GameId = 1,
                            PlatformId = 3,
                        },
                        new Platforms_Games()
                        {
                            GameId = 3,
                            PlatformId = 2,
                        },

                    });
                    context.SaveChanges();
                }
            }
        }
    }
}
