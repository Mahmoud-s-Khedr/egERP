import styled from 'styled-components';
import useTheme from '../Context/useTheme';
import { useState } from 'react';

const FilterContainer = styled.div`
  display: flex;
  align-items: center;
  flex-wrap: wrap;
  gap: 24px;
  margin-bottom: 24px;
  background-color: ${({ theme }) => theme.ComponentBackground};
  border-radius: 8px;
  padding: 24px;
`;

const FilterInput = styled.input`
  padding: 12px;
  border-radius: 4px;
  border: 1px solid ${({ theme }) => theme.lightgray};
  width: 40%;
  margin-right: 8px;
  color: ${({ theme }) => theme.text};
  background-color: ${({ theme }) => theme.ComponentBackground};
  font-size: 16px;
`;

const FilterButton = styled.button`
  padding: 12px 16px;
  border-radius: 4px;
  border: none;
  background-color: ${({ theme }) => theme.primary};
  color: ${({ theme }) => theme.white};
  cursor: pointer;
  font-size: 16px;
  &:hover {
    background-color: ${({ theme }) => theme.secondary};
  }
`;

const FilterLabel = styled.label`
  margin-right: 8px;
  width: 100%;
  font-size: 24px;
  color: ${({ theme }) => theme.text};
`;

const FilterSelect = styled.select`
  padding: 12px;
  border-radius: 4px;
  width: 30%;
  border: 1px solid ${({ theme }) => theme.lightgray};
  margin-right: 8px;
  color: ${({ theme }) => theme.text};
  background-color: ${({ theme }) => theme.ComponentBackground};
  font-size: 16px;
`;

function Filter({ onFilter }) {
  const { theme } = useTheme();
  const [filterText, setFilterText] = useState('');
  const [filterField, setFilterField] = useState('orderNumber');

  const handleFilterChange = (e) => {
    setFilterText(e.target.value);
    onFilter(filterField, e.target.value);
  };

  const handleFieldChange = (e) => {
    setFilterField(e.target.value);
  };

  return (
    <FilterContainer theme={theme}>
      <FilterLabel theme={theme}>Search:</FilterLabel>
      <FilterSelect theme={theme} onChange={handleFieldChange}>
        <option value="orderNumber">Order Number</option>
        <option value="customer">Customer</option>
        <option value="date">Date</option>
        <option value="status">Status</option>
      </FilterSelect>
      <FilterInput
        type="text"
        placeholder="Enter search term..."
        value={filterText}
        onChange={handleFilterChange}
        theme={theme}
      />
      <FilterButton theme={theme} onClick={() => onFilter(filterField, filterText)}>Filter</FilterButton>
    </FilterContainer>
  );
}

export default Filter;