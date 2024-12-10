import { BarChart, Bar, Rectangle, XAxis, YAxis, CartesianGrid, Tooltip, Legend, ResponsiveContainer } from 'recharts';
import useTheme from '../Context/useTheme';
import styled from 'styled-components';

const data = [
  {
    name: 'January',
    orders: 120,
  },
  {
    name: 'February',
    orders: 145,
  },
  {
    name: 'March',
    orders: 180,
  },
  {
    name: 'April',
    orders: 165,
  },
  {
    name: 'May',
    orders: 210,
  },
  {
    name: 'June',
    orders: 195,
  },
  {
    name: 'July',
    orders: 220,
  },
  {
    name: 'August',
    orders: 240,
  },
  {
    name: 'September',
    orders: 200,
  },
  {
    name: 'October',
    orders: 185,
  },
  {
    name: 'November',
    orders: 230,
  },
  {
    name: 'December',
    orders: 250,
  },
];
const Header = styled.header`
  font-size: 24px;
  margin-left: 24px;
  margin-bottom: 24px;
`
const BarChartsContainer = styled.div`
  background-color: ${({theme}) => theme.ComponentBackground};
  border-radius: 8px;
  color: ${({theme}) => theme.text};
  width: 50%;
  height: fit-content;
  padding: 16px;
`
function BarCharts ()  {
  const {theme} = useTheme();
  return (
    <BarChartsContainer theme={theme}>
        <Header >Order Per Months</Header>
    <ResponsiveContainer width="100%" height={300}>
      
      <BarChart
        data={data}
        margin={{
          top: 5,
          right: 30,
          left: 20,
          bottom: 5,
        }}
        width="100%"
        height="100%"
      >
        <CartesianGrid strokeDasharray="3 3" />
        <XAxis dataKey="name" stroke={theme.text} />
        <YAxis stroke={theme.text} />
        <Tooltip />
        <Legend />
        <Bar dataKey="orders" fill={theme.primary} activeBar={<Rectangle fill={theme.secondary} stroke="blue" />} />
      </BarChart>
    </ResponsiveContainer>
    </BarChartsContainer>
  );
};

export default BarCharts;