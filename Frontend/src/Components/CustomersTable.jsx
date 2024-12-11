import styled from 'styled-components';
import useTheme from '../Context/useTheme';
import { useNavigate } from 'react-router-dom';

const TableContainer = styled.div`
  background-color: ${({ theme }) => theme.ComponentBackground};  
  border-radius: 8px;
  width: ${({width}) => width};
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

const Button = styled.div`
  background-color: ${({ theme }) => theme.primary};
  color: white;
  border: none;
  width: fit-content;
  padding: 8px 16px;
  border-radius: 4px;
  cursor: pointer;
`;

const CustomerInfo = styled.div`
  display: flex;
  align-items: center;
  gap: 12px;
`;

const CustomerAvatar = styled.img`
  width: 40px;
  height: 40px;
  border-radius: 50%;
  object-fit: cover;
`;

const CustomerName = styled.div`
  font-weight: 500;
`;

const mockData = [
  {
    id: 1,
    name: "John Doe",
    avatar: "https://images.unsplash.com/photo-1472099645785-5658abf4ff4e?w=500",
    email: "john.doe@example.com",
    orders: 12,
    spent: "$2,450"
  },
  {
    id: 2,
    name: "Sarah Smith",
    avatar: "https://images.unsplash.com/photo-1438761681033-6461ffad8d80?w=500",
    email: "sarah.smith@example.com",
    orders: 8,
    spent: "$1,850"
  },
  {
    id: 3,
    name: "Michael Johnson",
    avatar: "https://images.unsplash.com/photo-1500648767791-00dcc994a43e?w=500",
    email: "michael.j@example.com",
    orders: 15,
    spent: "$3,200"
  }
];

function CustomersTable({ width = "100%" }) {
  const { theme } = useTheme();
  const navigate = useNavigate();

  return (
    <TableContainer theme={theme} width={width}>
      <Header theme={theme}>Customers</Header>
      <TableWrapper theme={theme}>
        <StyledTable>
          <thead>
            <tr>
              <Th theme={theme}>Customer</Th>
              <Th theme={theme}>Email</Th>
              <Th theme={theme}>Orders</Th>
              <Th theme={theme}>Total Spent</Th>
              <Th theme={theme}>Action</Th>
            </tr>
          </thead>
          <tbody>
            {mockData.map((customer) => (
              <Tr key={customer.id} theme={theme}>
                <Td theme={theme}>
                  <CustomerInfo>
                    <CustomerAvatar src={customer.avatar} alt={customer.name} />
                    <CustomerName>{customer.name}</CustomerName>
                  </CustomerInfo>
                </Td>
                <Td theme={theme}>{customer.email}</Td>
                <Td theme={theme}>{customer.orders}</Td>
                <Td theme={theme}>{customer.spent}</Td>
                <Td theme={theme}>
                  <Button theme={theme} onClick={() => navigate(`${customer.id}`)}>View Profile</Button>
                </Td>
              </Tr>
            ))}
          </tbody>
        </StyledTable>
      </TableWrapper>
    </TableContainer>
  );
}

export default CustomersTable;
