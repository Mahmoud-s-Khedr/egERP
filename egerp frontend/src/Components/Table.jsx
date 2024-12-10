import styled from 'styled-components';
import useTheme from '../Context/useTheme';

const TableContainer = styled.div`
  background-color: ${({ theme }) => theme.ComponentBackground};  
  border-radius: 8px;
  width:${({width}) => width};
  padding: 16px;
  overflow: hidden;
`;

const Header = styled.header`
  font-size: 24px;
  margin-left: 24px;
  color: ${({ theme }) => theme.text};
  margin-bottom: 24px;
`;

const TableWrapper = styled.div`
  width: 100%;
  overflow-x: auto;
  -webkit-overflow-scrolling: touch;
  &::-webkit-scrollbar {
    height: 8px;
  }
  &::-webkit-scrollbar-track {
    background: #f1f1f1;
    border-radius: 4px;
  }
  &::-webkit-scrollbar-thumb {
    background: ${({ theme }) => theme.primary};
    border-radius: 4px;
  }
`;

const StyledTable = styled.table`
  width: 100%;
  border-collapse: collapse;
  min-width: 600px;
`;

const Th = styled.th`
  text-align: left;
  padding: 12px;
  background-color: ${({ theme }) => theme.primary};
  color: ${({ theme }) => theme.white};
  white-space: nowrap;
  font-weight: 600;
  
  &:first-child {
    border-top-left-radius: 8px;
    border-bottom-left-radius: 8px;
  }
  
  &:last-child {
    border-top-right-radius: 8px;
    border-bottom-right-radius: 8px;
  }
`;

const Td = styled.td`
  padding: 12px;
  border-bottom: 1px solid ${({ theme }) => theme.background};
  white-space: nowrap;
  color: ${({ theme }) => theme.text};
`;

const Tr = styled.tr`
  background-color: ${({ theme }) => theme.ComponentBackground};
  
  &:hover {
    background-color: ${({ theme }) => theme.primary}20;
    td {
      color: ${({ theme }) => theme.primary};
    }
  }
`;

const Button = styled.button`
  background-color: ${({ theme }) => theme.primary};
  color: white;
  border: none;
  padding: 8px 16px;
  border-radius: 4px;
  cursor: pointer;
`;


const data = [
  {
    id: 1,
    orderNumber: "ORD-001",
    customer: "John Doe",
    date: "2023-12-09",
    status: "Completed",
    total: "$1,200"
  },
  {
    id: 2,
    orderNumber: "ORD-002",
    customer: "Jane Smith",
    date: "2023-12-08",
    status: "Pending",
    total: "$850"
  },
  {
    id: 3,
    orderNumber: "ORD-003",
    customer: "Bob Johnson",
    date: "2023-12-07",
    status: "Processing",
    total: "$2,100"
  },
  {
    id: 4,
    orderNumber: "ORD-004",
    customer: "Alice Brown",
    date: "2023-12-06",
    status: "Completed",
    total: "$1,500"
  },
  {
    id: 5,
    orderNumber: "ORD-005",
    customer: "Charlie Wilson",
    date: "2023-12-05",
    status: "Completed",
    total: "$900"
  }
];

function Table({width}) {
  const {theme} = useTheme();

  return (
    <TableContainer theme={theme} width={width}>
      <Header theme={theme}>Recent Orders</Header>
      <TableWrapper theme={theme}>
        <StyledTable theme={theme}>
          <thead>
            <tr>
              <Th theme={theme}>Order Number</Th>
              <Th theme={theme}>Customer</Th>
              <Th theme={theme}>Date</Th>
              <Th theme={theme}>Status</Th>
              <Th theme={theme}>Actions</Th>
            </tr>
          </thead>
          <tbody>
            {data.map((row) => (
              <Tr key={row.id} theme={theme}>
                <Td theme={theme}>{row.orderNumber}</Td>
                <Td theme={theme}>{row.customer}</Td>
                <Td theme={theme}>{row.date}</Td>
                <Td theme={theme}>{row.status}</Td>
                <Td theme={theme}>{<Button theme={theme}>View Details</Button>}</Td>
              </Tr>
            ))}
          </tbody>
        </StyledTable>
      </TableWrapper>
    </TableContainer>
  );
}

export default Table;