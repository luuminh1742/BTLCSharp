using QuanLyNhaChoThue.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaChoThue.Utils
{
    class StatisticUtil
    {
        public int finished = 0;
		public int unfinished = 0;
		public string date = "";

		public StatisticUtil()
		{
			this.unfinished = 0;
			this.finished = 0;
		}
		public StatisticUtil(int unfinished, int finished, string date)
		{
			this.unfinished = unfinished;
			this.finished = finished;
			this.date = date;
		}

		public List<StatisticUtil> convert(List<ViewStatisticDTO> list)
		{
			List<StatisticUtil> result = new List<StatisticUtil>();
			try
			{
				string d = list[0].Date;
				foreach (ViewStatisticDTO roomSS in list)
				{
					if (roomSS.Date.Equals(d))
					{
						if (roomSS.Status == false)
						{
							unfinished = roomSS.Count;
						}
						if (roomSS.Status == true)
						{
							finished = roomSS.Count;
						}
						if (roomSS == list[list.Count - 1])
						{
							result.Add(new StatisticUtil(unfinished, finished, d));
						}
					}
					else
					{
						result.Add(new StatisticUtil(unfinished, finished, d));
						unfinished = 0;
						finished = 0;
						d = roomSS.Date;
						if (roomSS.Status == false)
						{
							unfinished = roomSS.Count;
						}
						if (roomSS.Status == true)
						{
							finished = roomSS.Count;
						}
						if (roomSS == list[(list.Count - 1)])
						{
							result.Add(new StatisticUtil(unfinished, finished, d));
						}

					}
				}
				return result;
			}catch(Exception ex)
            {
				return null;
            }
		}
	}
}
