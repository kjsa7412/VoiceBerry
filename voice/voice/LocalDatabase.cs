using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace voice
{
    class LocalDatabase
    {
        public static string chk1;
        public static string chk2;

        public static List<string> Imsi_Title = new List<string>();
        public static List<string> Imsi_Content = new List<string>();
        public static List<string> Imsi_Time = new List<string>();
        public static List<string> Imsi_Back = new List<string>();

        public static string MainTitle;
        public static string Temp;
        public static List<string> User_Name = new List<string>();
        public static List<string> User_Pic = new List<string>();

        public static List<string> Write_MainTitle = new List<string>();
        public static List<string> Write_SubTitle = new List<string>();
        public static List<string> Write_SubContent = new List<string>();

        public static List<string> Write_Gender = new List<string>();
        public static List<string> Write_AgeTo = new List<string>();
        public static List<string> Write_AgeFrom = new List<string>();
        public static List<string> Write_Audience = new List<string>();
        public static List<string> Write_Purpose = new List<string>();
        public static List<string> Write_Additional = new List<string>();
        public static List<string> Write_Public = new List<string>();
        public static List<string> Write_AllFriends = new List<string>();

        public static List<string> Write_Time = new List<string>();
        public static List<string> Write_Date= new List<string>();


        public static List<string> Folder_Title = new List<string>();
        public static List<string> Voice_Title = new List<string>();
        //public static List<string> User_Pic = new List<string>();
        //public static List<string> User_Pic = new List<string>();

        public static List<string> Pad_Title = new List<string>();
        public static List<string> Pad_Time = new List<string>();
        public static List<string> Pad_Date = new List<string>();

        public static List<string> Pad_Sub_Title = new List<string>();
        public static List<string> Pad_Sub_Time = new List<string>();
        public static List<string> Pad_Sub_Content = new List<string>();
        
        //의뢰페이지에서 저장
        public static string Save_MainTitle;
        public static List<string> Save_SubTitle = new List<string>();

        //의뢰완료시 저장

        public static void SetDatabase()
        {
            Pad_Title.Add("Pusan Univ Class");
            Pad_Time.Add("00:10:00");
            Pad_Date.Add("15. 01. 2015");

            Pad_Title.Add("Seoul Univ Class");
            Pad_Time.Add("00:10:00");
            Pad_Date.Add("15. 01. 2015");

            Pad_Title.Add("Interview");
            Pad_Time.Add("00:10:00");
            Pad_Date.Add("15. 01. 2015");

            Pad_Sub_Title.Add("Page1");
            Pad_Sub_Title.Add("Page2");
            Pad_Sub_Title.Add("Page3");

            Pad_Sub_Time.Add("00:00:10");
            Pad_Sub_Time.Add("00:02:00");
            Pad_Sub_Time.Add("00:07:50");

            Pad_Sub_Title.Add("Page1");
            Pad_Sub_Title.Add("Page2");
            Pad_Sub_Title.Add("Page3");

            Pad_Sub_Time.Add("00:00:10");
            Pad_Sub_Time.Add("00:02:00");
            Pad_Sub_Time.Add("00:07:50");

            Pad_Sub_Title.Add("Page1");
            Pad_Sub_Title.Add("Page2");
            Pad_Sub_Title.Add("Page3");

            Pad_Sub_Time.Add("00:00:10");
            Pad_Sub_Time.Add("00:02:00");
            Pad_Sub_Time.Add("00:07:50");

            Pad_Sub_Content.Add("hi");
            Pad_Sub_Content.Add("my name is Seungmoo");
            Pad_Sub_Content.Add("We are team arirang");

            Pad_Sub_Content.Add("hi");
            Pad_Sub_Content.Add("my name is Seungmoo");
            Pad_Sub_Content.Add("We are team arirang");

            Pad_Sub_Content.Add("hi");
            Pad_Sub_Content.Add("my name is Seungmoo");
            Pad_Sub_Content.Add("We are team arirang");

            User_Name.Add("Yumi1");
            User_Name.Add("Yumi2");

            User_Pic.Add("Assets/profile/profile_pic.png");
            User_Pic.Add("Assets/profile/profile_pic.png");

            Folder_Title.Add("Biology");
            Folder_Title.Add("Interview");

            Voice_Title.Add("Biology - ");


            //기부자메인(공개의뢰)

            Write_MainTitle.Add("Pusan Univ Class");
            Write_MainTitle.Add("Seoul Univ Class");
            Write_MainTitle.Add("Interview");

            Write_Gender.Add("male");
            Write_Gender.Add("male");
            Write_Gender.Add("male");

            Write_AgeTo.Add("20");
            Write_AgeTo.Add("21");
            Write_AgeTo.Add("22");


            Write_AgeFrom.Add("28");
            Write_AgeFrom.Add("29");
            Write_AgeFrom.Add("30");


            Write_Audience.Add("Pusan Class Mate");
            Write_Audience.Add("Seoul Class Mate");
            Write_Audience.Add("Pusan Univ Student");

            Write_Purpose.Add("Lecture");
            Write_Purpose.Add("Lecture");
            Write_Purpose.Add("Send Information");


            Write_Additional.Add("Please");
            Write_Additional.Add("Please");
            Write_Additional.Add("Please");

            Write_Public.Add("Public");
            Write_Public.Add("Public");
            Write_Public.Add("Public");

            Write_AllFriends.Add("All");
            Write_AllFriends.Add("All");
            Write_AllFriends.Add("All");

            Write_Date.Add("Wednesday, jan, 15 2015");
            Write_Date.Add("Wednesday, jan, 15 2015");
            Write_Date.Add("Wednesday, jan, 15 2015");

            Write_Time.Add("05:40 PM");
            Write_Time.Add("05:41 PM");
            Write_Time.Add("05:42 PM");


            //Write_SubTitle;
            //Write_SubContent;
        }
    }
}
