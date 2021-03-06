﻿using Chart.Mvc.Charts;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chart.Mvc6.TagHelpers
{
    public class LineChartTagHelper : ChartTagHelperBase<LineChartOptions> {}
    public class BarChartTagHelper : ChartTagHelperBase<BarChartOptions> { }
    public class RadarChartTagHelper : ChartTagHelperBase<RadarChartOptions> { }
    public class PolarChartTagHelper : ChartTagHelperBase<PolarAreaOptions> { }
    public class PieChartTagHelper : ChartTagHelperBase<PieChartOptions> { }
    public class DoughnutChartTagHelper : ChartTagHelperBase<DoughnutChartOptions> { }
}
