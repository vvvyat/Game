﻿namespace FishWorld
{
    public class Map
    {
        public static char[][,] Maps = new char[][,]
        {
            new char[,]
            {
                {'.', '.', '.', '.', '.', '.', '.', '.', '.', '.', 'ж', '.', '.', 'к', '.', '.', '.', 'к', 'к', '.', '.', 'к', 'к', '.', '.', '.', '.', '.', '.', 'в', 'в', 'в', '.', '.', '.', '.', '.', '.', 'к', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', 'ж', '.', '.', '.', '.', 'к', 'к', '.', '.', '.', '.', '.', '.', '.', 'к', 'в', '.', '.', '.', '.', '.', 'в', '.', '.', '.', '.', '.', '.', '.', '.'},
                {'.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', 'к', '.', '.', '.', '.', '.', '.', 'ж', '.', '.', 'к', '.', '.', '.', '.', '.', '.', '.', 'в', '.', '.', '.', '.', '.', '.', 'к', '.', 'в', '.', 'в', '.', 'ж', '.', '.', '.', 'к', '.', '.', 'ж', '.', '.', '.', '.', '.', 'к', 'в', '.', '.', '.', '.', '.', 'в', '.', '.', '.', 'ж', 'в', 'в', '.', '.', '.', 'ж', '.', 'ж', '.'},
                {'ж', '.', 'ж', '.', '.', '.', '.', '.', 'ж', '.', '.', '.', 'ж', '.', '.', '.', 'к', '.', '.', 'ж', '.', '.', '.', '.', '.', '.', '.', 'к', '.', '.', '.', 'в', '.', '.', '.', '.', '.', '.', '.', '.', '.', 'к', '.', '.', '.', '.', '.', '.', 'к', '.', '.', 'в', 'в', '.', '.', 'ж', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', 'в', '.', '.', '.', 'в', 'в', 'в', '.', 'ж', 'ж', 'ж', 'ж', 'ж'},
                {'.', '.', '.', '.', 'ж', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', 'ж', '.', '.', '.', 'к', '.', '.', '.', '.', 'к', '.', 'ж', '.', '.', '.', 'в', 'в', 'в', '.', '.', '.', '.', 'ж', '.', '.', '.', '.', 'в', 'в', '.', '.', 'в', '.', '.', '.', '.', '.', 'к', '.', '.', '.', '.', '.', '.', 'к', '.', 'в', '.', '.', '.', '.', '.', '.', 'в', 'в', 'в', '.', '.', 'ж', 'ж', 'ж', '.'},
                {'.', '.', '.', '.', '.', '.', 'ж', '.', '.', '.', '.', '.', '.', '.', 'ж', '.', '.', '.', '.', '.', '.', '.', '.', 'ж', '.', 'ж', '.', '.', '.', '.', '.', 'в', 'в', '.', '.', '.', '.', 'ж', '.', '.', '.', '.', '.', 'в', '.', '.', '.', '.', 'в', 'в', '.', '.', '.', '.', '.', '.', '.', '.', 'ж', '.', '.', 'к', 'к', '.', 'в', '.', 'ж', '.', '.', 'к', 'в', 'в', '.', '.', '.', '.', 'ж', '.', '.'},
                {'.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', 'к', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', 'к', '.', '.', 'в', 'в', 'в', '.', 'в', '.', 'к', 'к', '.', '.', '.', '.', '.', 'к', '.', '.', '.', '.', 'к', 'к', '.', '.', '.', '.', '.', '.', 'ж', '.', '.', 'ж', 'ж', '.', '.', '.', '.', 'к', '.', 'в', '.', '.', '.', '.', '.', '.', '.', '.'}
            },
            new char[,]
            {
                {'.', '.', 'в', '.', '.', '.', '.', '.', '.', '.', 'к', '.', '.', 'к', '.', '.', '.', 'в', 'в', '.', '.', '.', '.', '.', '.', '.', '.', 'в', 'в', '.', 'к', '.', '.', '.', '.', 'в', 'в', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', 'к', 'в', '.', '.', '.', 'к', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', 'к', '.', 'к', '.', '.', '.', '.', '.', '.', 'к', 'в', '.', '.', '.', '.', '.', 'к', '.', '.', '.', '.', '.', '.', '.', '.'},
                {'в', 'в', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', 'к', '.', '.', '.', '.', '.', '.', 'в', 'в', '.', '.', '.', '.', '.', '.', '.', 'в', '.', 'к', '.', '.', '.', '.', '.', '.', 'к', '.', '.', '.', 'к', '.', '.', '.', '.', 'к', '.', '.', '.', 'к', '.', '.', '.', '.', '.', '.', 'к', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', 'к', 'в', '.', '.', '.', '.', '.', '.', 'к', '.', 'ж', '.', '.', '.', '.', '.', '.', '.', '.', '.'},
                {'в', '.', 'ж', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', 'к', '.', '.', '.', '.', 'ж', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', 'к', '.', '.', 'ж', '.', '.', '.', '.', '.', '.', '.', 'к', '.', '.', '.', '.', '.', 'к', '.', 'в', '.', 'ж', '.', '.', '.', 'к', '.', '.', '.', 'в', 'в', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', 'в', '.', '.', '.', '.', '.', '.', '.', 'ж', 'ж', 'ж', 'ж', 'ж'},
                {'.', '.', '.', '.', 'ж', '.', '.', '.', '.', '.', 'к', 'в', '.', '.', '.', '.', '.', 'ж', '.', '.', '.', '.', '.', '.', 'к', '.', '.', '.', '.', '.', '.', '.', '.', '.', 'ж', '.', '.', '.', '.', 'в', 'в', '.', '.', '.', '.', '.', '.', '.', 'ж', '.', '.', 'ж', '.', '.', '.', '.', 'ж', '.', '.', '.', 'к', '.', '.', '.', '.', '.', '.', 'к', '.', '.', '.', '.', 'к', '.', 'в', '.', '.', '.', '.', '.', '.', 'в', '.', 'в', '.', '.', '.', '.', '.', '.'},
                {'.', '.', '.', '.', '.', '.', 'ж', '.', 'ж', '.', '.', '.', '.', '.', 'ж', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', 'ж', '.', '.', '.', '.', '.', '.', 'в', 'в', '.', '.', '.', '.', '.', '.', '.', 'ж', '.', '.', '.', '.', '.', 'к', '.', '.', '.', '.', '.', '.', 'в', '.', '.', 'к', '.', '.', '.', '.', '.', '.', '.', 'ж', '.', 'к', 'к', '.', 'в', '.', 'ж', '.', '.', 'к', 'в', 'в', '.', '.', '.', '.', '.', '.', '.'},
                {'.', '.', '.', '.', 'к', 'в', '.', '.', '.', '.', '.', 'ж', '.', '.', '.', '.', '.', 'к', '.', '.', '.', '.', '.', '.', '.', 'в', '.', '.', 'к', '.', '.', '.', 'ж', '.', '.', '.', 'к', '.', '.', '.', 'в', '.', '.', '.', '.', '.', 'в', '.', 'к', 'к', '.', '.', 'к', '.', '.', 'к', '.', '.', '.', '.', '.', '.', 'ж', 'ж', '.', '.', '.', '.', '.', '.', '.', 'ж', '.', 'ж', '.', '.', '.', '.', '.', 'к', '.', 'в', '.', '.', '.', '.', '.', '.', '.', '.'}
            },
            new char[,]
            {
                {'в', 'в', '.', '.', '.', '.', '.', '.', '.', '.', 'в', 'в', '.', 'к', '.', '.', '.', '.', 'к', '.', '.', 'к', '.', '.', 'к', 'к', '.', '.', '.', '.', '.', '.', '.', 'в', 'в', 'в', '.', '.', '.', '.', '.', '.', 'к', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', 'ж', '.', '.', '.', '.', '.', '.', 'к', 'к', '.', '.', '.', '.', '.', '.', '.', 'к', 'в', '.', '.', '.', '.', '.', 'в', '.', '.', '.', '.', '.', '.', '.', '.'},
                {'к', '.', 'в', '.', '.', '.', '.', '.', '.', 'к', '.', '.', '.', '.', 'к', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', 'к', '.', '.', '.', '.', '.', '.', '.', '.', 'в', '.', '.', '.', '.', '.', '.', 'к', '.', '.', '.', 'в', '.', 'в', '.', '.', '.', '.', 'ж', '.', '.', '.', '.', '.', 'к', '.', '.', '.', '.', 'ж', '.', '.', '.', '.', '.', 'к', 'в', '.', '.', 'в', '.', '.', 'в', '.', '.', '.', '.', 'в', 'в', '.', '.', '.', '.', '.', '.', '.'},
                {'.', '.', '.', 'в', '.', '.', '.', '.', 'к', '.', '.', '.', 'ж', '.', '.', '.', 'к', '.', '.', '.', '.', '.', 'в', '.', '.', '.', '.', '.', '.', '.', '.', 'к', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', 'к', '.', '.', '.', '.', '.', '.', '.', '.', 'в', '.', 'к', '.', '.', '.', '.', 'в', '.', 'в', '.', '.', 'ж', '.', '.', '.', '.', '.', '.', 'к', '.', '.', '.', 'в', '.', '.', '.', '.', '.', '.', '.', 'ж', 'ж', 'ж', 'ж', '.'},
                {'.', '.', '.', '.', 'в', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', 'в', '.', 'к', '.', '.', '.', 'к', '.', '.', '.', '.', '.', 'к', '.', '.', 'ж', '.', '.', '.', '.', 'к', '.', '.', '.', '.', 'ж', '.', '.', '.', '.', '.', '.', 'в', '.', '.', '.', 'в', '.', '.', 'в', 'в', '.', '.', '.', '.', '.', '.', '.', '.', 'к', '.', '.', '.', '.', '.', '.', '.', '.', 'в', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', 'ж', 'ж', 'ж', 'ж', '.'},
                {'к', '.', '.', '.', '.', '.', '.', 'ж', '.', '.', '.', '.', '.', '.', 'ж', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', 'ж', '.', '.', '.', '.', '.', '.', 'в', '.', '.', '.', '.', '.', 'ж', '.', '.', '.', '.', '.', '.', '.', 'в', '.', '.', '.', '.', '.', '.', '.', '.', 'в', '.', 'в', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', 'в', '.', 'ж', '.', '.', '.', 'в', 'в', '.', '.', '.', '.', '.', '.', '.'},
                {'к', '.', '.', '.', '.', 'ж', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', 'ж', '.', '.', '.', '.', '.', '.', 'в', 'в', 'в', '.', '.', '.', '.', '.', '.', '.', '.', 'к', '.', '.', '.', '.', 'ж', '.', 'в', '.', 'к', 'к', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', 'к', '.', '.', '.', '.', '.', '.', '.', 'к', '.', 'к', '.', '.', '.', '.', '.', '.', '.', '.', '.', 'ж', 'ж', '.', '.', '.', '.', '.', '.', 'в', '.', '.', '.', '.', '.', '.', '.', '.'}
            }
        };
    }
}