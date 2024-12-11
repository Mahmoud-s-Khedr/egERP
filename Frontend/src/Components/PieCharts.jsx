import { PieChart, Pie, Sector, ResponsiveContainer } from 'recharts';
import useTheme from '../Context/useTheme';
import styled from 'styled-components';
import { useState } from 'react';

const data = [
  { name: 'Egypt', value: 400 },
  { name: 'Saudi Arabia', value: 300 },
  { name: 'UAE', value: 250 },
  { name: 'Kuwait', value: 200 },
  { name: 'Qatar', value: 150 },
];

const Header = styled.header`
  font-size: 24px;
  margin-left: 24px;
  margin-bottom: 24px;
  color: ${({theme}) => theme.text};
`

const PieChartsContainer = styled.div`
  background-color: ${({theme}) => theme.ComponentBackground};
  border-radius: 8px;
  width: ${({width}) => width};
  padding: 16px;
`

const renderActiveShape = (props) => {
  const RADIAN = Math.PI / 180;
  const { cx, cy, midAngle, innerRadius, outerRadius, startAngle, endAngle, fill, payload, percent, value } = props;
  const sin = Math.sin(-RADIAN * midAngle);
  const cos = Math.cos(-RADIAN * midAngle);
  const sx = cx + (outerRadius + 10) * cos;
  const sy = cy + (outerRadius + 10) * sin;
  const mx = cx + (outerRadius + 30) * cos;
  const my = cy + (outerRadius + 30) * sin;
  const ex = mx + (cos >= 0 ? 1 : -1) * 22;
  const ey = my;
  const textAnchor = cos >= 0 ? 'start' : 'end';
  
  return (
    <g>
      <text x={cx} y={cy} dy={8} textAnchor="middle" fill={props.theme.text}>
        {payload.name}
      </text>
      <Sector
        cx={cx}
        cy={cy}
        innerRadius={innerRadius}
        outerRadius={outerRadius}
        startAngle={startAngle}
        endAngle={endAngle}
        fill={fill}
      />
      <Sector
        cx={cx}
        cy={cy}
        startAngle={startAngle}
        endAngle={endAngle}
        innerRadius={outerRadius + 6}
        outerRadius={outerRadius + 10}
        fill={fill}
      />
      <path d={`M${sx},${sy}L${mx},${my}L${ex},${ey}`} stroke={fill} fill="none" />
      <circle cx={ex} cy={ey} r={2} fill={fill} stroke="none" />
      <text x={ex + (cos >= 0 ? 1 : -1) * 12} y={ey} textAnchor={textAnchor} fill={props.theme.text}>
        {`Customers: ${value}`}
      </text>
      <text x={ex + (cos >= 0 ? 1 : -1) * 12} y={ey} dy={18} textAnchor={textAnchor} fill={props.theme.text}>
        {`(${(percent * 100).toFixed(2)}%)`}
      </text>
    </g>
  );
};

function PieCharts({width}) {
  const [activeIndex, setActiveIndex] = useState(0);
  const {theme} = useTheme();

  const onPieEnter = (_, index) => {
    setActiveIndex(index);
  };

  return (
    <PieChartsContainer width={width} theme={theme}>
      <Header theme={theme}>Customers per Country</Header>
      <ResponsiveContainer width="100%" height={300}>
        <PieChart>
          <Pie
            activeIndex={activeIndex}
            activeShape={(props) => renderActiveShape({...props, theme})}
            data={data}
            cx="50%"
            cy="50%"
            innerRadius={70}
            outerRadius={100}
            fill={theme.secondary}
            dataKey="value"
            onMouseEnter={onPieEnter}
          />
        </PieChart>
      </ResponsiveContainer>
    </PieChartsContainer>
  );
}

export default PieCharts;