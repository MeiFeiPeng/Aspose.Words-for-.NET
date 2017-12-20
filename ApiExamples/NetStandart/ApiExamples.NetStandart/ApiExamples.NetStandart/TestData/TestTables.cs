﻿namespace ApiExamples.NetStandart.TestData
{
    partial class DataSet
    {
        internal static DataSet AddTestData()
        {
            DataSet ds = new DataSet();

            int age = 30;
            int j = 1;

            for (int i = 1; i <= 10; i++)
            {
                ds.Clients.Rows.Add(i, "Name " + i);
            }

            for (int i = 1; i <= 3; i++)
            {
                for (int y = j; y <= j + 2; y++)
                {
                    ds.Contracts.Rows.Add(y, y, i, 1000);
                }

                j = j + 3;
            }

            for (int i = 1; i <= 3; i++)
            {
                ds.Managers.Rows.Add(i, "Name " + i, age);
                age = age + 1;
            }

            return ds;
        }
    }
}
