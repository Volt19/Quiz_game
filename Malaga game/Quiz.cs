using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Malaga_game
{
    public class Quiz
    {
        private static int numberOfQuestions = 17;
        private static int numberOfAnswers = 4;
        public string[] questions = new string[numberOfQuestions];
        public string[,] answers = new string[numberOfQuestions,numberOfAnswers];
        public static string timeL;
        public static string points;
        public  Quiz()
        {
            NumberOfQuestions = numberOfQuestions;

            //questions[] = "";
            //answers[, 0] = "";
            //answers[, 1] = "";
            //answers[, 2] = "";
            //answers[, 3] = "";

            questions[0] = "What is poverty threshold?";
            answers[0, 0] = "the resources needed for one person to live in a year";
            answers[0, 1] = "the minimum for a family in a day";
            answers[0, 2] = "All answers are correct"; //All answers are wrong
            answers[0, 3] = "Minimum level of income deemed adequate in a particular country";

            questions[1] = " What is the poverty rate?";
            answers[1, 0] = "2%"; 
            answers[1, 1] = "30%"; 
            answers[1, 2] = "32%"; 
            answers[1, 3] = "9%";

            questions[2] = "How much money would have to be given to the people a day to bring them up to the poverty line?";
            answers[2, 0] = "$9";
            answers[2, 1] = "$7";
            answers[2, 2] = "$3";
            answers[2, 3] = "1,9$";

            questions[3] = "In the United States, about what share of income did the top 1% of households hold in 2014?";
            answers[3, 0] = "26%";
            answers[3, 1] = "21% ";
            answers[3, 2] = "6% ";
            answers[3, 3] = "49% ";

            questions[4] = "What percent of world's poor live in India?";
            answers[4, 0] = "10%";
            answers[4, 1] = "All answers are wrong";
            answers[4, 2] = "30%";
            answers[4, 3] = "20%";

            questions[5] = "What does NOT cause poverty?";
            answers[5, 0] = "Weather/climate change";
            answers[5, 1] = "Lack of job/education";
            answers[5, 2] = "Lack of infrastructure";
            answers[5, 3] = "All answers are wrong";

            questions[6] = "How many children under the age of five die annually in India according to UNICEF?";
            answers[6, 0] = "1,9 mil";
            answers[6, 1] = "3 mil";
            answers[6, 2] = "2,8 mil";
            answers[6, 3] = "2,3 mil ";

            questions[7] = "Two KEY features of the poorest households?";
            answers[7, 0] = "no education and job ";
            answers[7, 1] = "no health and life care";
            answers[7, 2] = "All answers are correct";
            answers[7, 3] = "hunger and starvation";

            questions[8] = "Which of the following programmes DOES NOT aim at improving the food and nutritional status of the poor?";
            answers[8, 0] = "Mid-day Meal";
            answers[8, 1] = "Integrated Child Development Scheme";
            answers[8, 2] = "Co-curricular activities (CCA)";
            answers[8, 3] = "Public Distribution System";

            questions[9] = "Problems NOT faced by the poor:";
            answers[9, 0] = "no electricity and clean water";
            answers[9, 1] = "unemployment";
            answers[9, 2] = "less motherhood care";
            answers[9, 3] = "All answers are correct";

            questions[10] = "How many people stay hungry every day?";
            answers[10, 0] = "1  million ";
            answers[10, 1] = "770  million";
            answers[10, 2] = "820 million ";
            answers[10, 3] = "137 million ";

            questions[11] = "Аfter how many days the body begins to starve?";
            answers[11, 0] = " 2 days";
            answers[11, 1] = "3 days";
            answers[11, 2] = "5 days";
            answers[11, 3] = "1 day";

            questions[12] = "How many people die of hunger every day?";
            answers[12, 0] = "21 thousand people";
            answers[12, 1] = "13 thousand people";
            answers[12, 2] = " 50 thousand people";
            answers[12, 3] = "1 milion people";

            questions[13] = "How many people are at risk of starving? ";
            answers[13, 0] = "135 million";
            answers[13, 1] = "108 million people";
            answers[13, 2] = "507 thousand people";
            answers[13, 3] = "834 thousand people";

            questions[14] = "How many  tons of food are thrown away in the world per year?";
            answers[14, 0] = "Half billion tons of food ";
            answers[14, 1] = "3 billion tons ";
            answers[14, 2] = "2.4 billion tons ";
            answers[14, 3] = "1.3 billion tons";

            questions[15] = "What needs to be done to reduce the world's poverty rate?";
            answers[15, 0] = "decrease in bills";
            answers[15, 1] = "increase in birth rate ";
            answers[15, 2] = " decrease in income ";
            answers[15, 3] = "increase in income";

            questions[16] = "How much does it cost to provide a child with all of the vitamins and nutrients he or she needs to grow up healthy?";
            answers[16, 0] = "1.00 $ per day";
            answers[16, 1] = "2.00 $ per day";
            answers[16, 2] = "2.30 $ per day";
            answers[16, 3] = "0.25 $ per day";
        }
        
        public int NumberOfQuestions
        {
            get; set;
        }

        //public string[] Questions
        //{
        //    get; set;
        //}


    }
}
