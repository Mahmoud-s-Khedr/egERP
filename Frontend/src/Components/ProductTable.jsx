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

const Button = styled.button`
  background-color: ${({color}) => color};
  color: white;
  border: none;
  padding: 8px 16px;
  border-radius: 4px;
  cursor: pointer;
  margin-right: 8px;

  &:last-child {
    margin-right: 0;
  }
`;

const ProductInfo = styled.div`
  display: flex;
  align-items: center;
  gap: 12px;
`;

const ProductImage = styled.img`
  width: 40px;
  height: 40px;
  border-radius: 4px;
  object-fit: cover;
`;

const ProductName = styled.span`
  font-weight: 500;
`;

const mockData = [
  {
    id: 1,
    name: "Wireless Headphones",
    image: "https://images.unsplash.com/photo-1505740420928-5e560c06d30e?w=500",
    price: "$199.99",
    stock: 45,
    orders: 128
  },
  {
    id: 2,
    name: "Smart Watch",
    image: "https://images.unsplash.com/photo-1523275335684-37898b6baf30?w=500",
    price: "$299.99",
    stock: 32,
    orders: 89
  },
  {
    id: 3,
    name: "Laptop Pro",
    image: "https://images.unsplash.com/photo-1496181133206-80ce9b88a853?w=500",
    price: "$1299.99",
    stock: 12,
    orders: 45
  }
];

function ProductTable({ width = "100%" }) {
  const { theme } = useTheme();
  const navigate = useNavigate();

  return (
    <TableContainer theme={theme} width={width}>
      <Header theme={theme}>Products</Header>
      <TableWrapper theme={theme}>
        <StyledTable>
          <thead>
            <tr>
              <Th theme={theme}>Product</Th>
              <Th theme={theme}>Price</Th>
              <Th theme={theme}>Stock</Th>
              <Th theme={theme}>Orders</Th>
              <Th theme={theme}>Actions</Th>
            </tr>
          </thead>
          <tbody>
            {mockData.map((product) => (
              <Tr key={product.id} theme={theme}>
                <Td theme={theme}>
                  <ProductInfo>
                    <ProductImage src={product.image} alt={product.name} />
                    <ProductName>{product.name}</ProductName>
                  </ProductInfo>
                </Td>
                <Td theme={theme}>{product.price}</Td>
                <Td theme={theme}>{product.stock}</Td>
                <Td theme={theme}>{product.orders}</Td>
                <Td theme={theme}>
                  <Button theme={theme} color={theme.primary} onClick={() => navigate(`${product.id}`)}>View Details</Button>
                  <Button theme={theme} color={theme.secondary}>Add Order</Button>
                </Td>
              </Tr>
            ))}
          </tbody>
        </StyledTable>
      </TableWrapper>
    </TableContainer>
  );
}

export default ProductTable;