import React, { useState } from "react";
import styled from "styled-components";

// Styled Components with Theme Support
const FilterContainer = styled.div`
  background-color: ${({ theme }) => theme.componentBackground};
  color: ${({ theme }) => theme.text};
  padding: 20px;
  border-radius: 10px;
  width: calc(100% - 40px);
  box-shadow: rgba(0, 0, 0, 0.35) 0px 5px 15px;
`;

const TitleBar = styled.div`
  display: flex;
  justify-content: space-between;
  align-items: center;
`;

const Title = styled.h3`
  font-size: 1.2rem;
`;

const ResetButton = styled.button`
  background: none;
  color: ${({ theme }) => theme.secondaryText};
  border: none;
  font-size: 1rem;
  cursor: pointer;

  &:hover {
    color: ${({ theme }) => theme.text};
  }
`;

const Section = styled.div`
  margin-top: 20px;
`;

const SectionTitle = styled.h4`
  font-size: 1rem;
  margin-bottom: 10px;
`;

const RadioGroup = styled.div`
  display: flex;
  flex-direction: column;
  gap: 8px;
`;

const RadioButton = styled.label`
  display: flex;
  align-items: center;
  gap: 8px;
  font-size: 0.9rem;
  cursor: pointer;

  input {
    accent-color: ${({ theme }) => theme.accent};
  }
`;

const Slider = styled.div`
  display: flex;
  flex-direction: column;
  margin-top: 10px;

  input[type="range"] {
    width: 100%;
    margin: 10px 0;
    font-family: 'Poppins', sans-serif;
    accent-color: ${({ theme }) => theme.accent};
  }

  .range-labels {
    display: flex;
    justify-content: space-between;
    font-size: 0.8rem;
    color: ${({ theme }) => theme.secondaryText};
  }
`;

const CheckboxGroup = styled.div`
  display: flex;
  flex-direction: column;
  gap: 8px;
`;

const SelectInputContainer = styled.div`
  display: flex;
  gap: 10px;
  margin-top: 10px;
  font-family: 'Poppins', sans-serif;
  select,
  input {
    flex: 1;
    padding: 4px;
    border-radius: 5px;
    border: 1px solid ${({ theme }) => theme.border};
    background-color:white;
    color: black;
    font-family: 'Poppins', sans-serif;

    &:focus {
      outline: none;
      border-color: ${({ theme }) => theme.accent};
    }
  }
`;

const ApplyButton = styled.button`
  margin-top: 20px;
  width: 100%;
  padding: 10px;
  font-size: 1rem;
  background-color: ${({ theme }) => theme.accent};
  color: white;
  border: none;
  border-radius: 5px;
  cursor: pointer;

  &:hover {
    background-color: ${({ theme }) => theme.accentHover};
  }
`;

// Main Component
const FilterForm = ({ onFilter, theme }) => {
  const [filters, setFilters] = useState({
    sortBy: "name",
    spendRange: [0, 10000],
    orderRange: [0, 100],
    searchField: "name",
    searchValue: "",
  });

  const handleFilterChange = (key, value) => {
    setFilters((prev) => ({
      ...prev,
      [key]: value,
    }));
  };

  const handleSliderChange = (key, index, value) => {
    setFilters((prev) => {
      const updatedRange = [...prev[key]];
      updatedRange[index] = Number(value);
      return { ...prev, [key]: updatedRange };
    });
  };

  const resetFilters = () => {
    setFilters({
      sortBy: "name",
      spendRange: [0, 10000],
      orderRange: [0, 100],
      searchField: "name",
      searchValue: "",
    });
  };

  const applyFilters = () => {
    onFilter(filters); // Pass the filters to the parent component
  };

  return (
    <FilterContainer theme={theme}>
      <TitleBar>
        <Title>Filters</Title>
        <ResetButton onClick={resetFilters}>Reset All</ResetButton>
      </TitleBar>

      {/* Sort By */}
      <Section>
        <SectionTitle>Sort By</SectionTitle>
        <RadioGroup>
          
          <RadioButton theme={theme}>
            <input
              type="radio"
              name="sortBy"
              value="totalSpend"
              checked={filters.sortBy === "totalSpend"}
              onChange={(e) => handleFilterChange("sortBy", e.target.value)}
            />
            Total Spend
          </RadioButton>
          <RadioButton theme={theme}>
            <input
              type="radio"
              name="sortBy"
              value="numOrders"
              checked={filters.sortBy === "numOrders"}
              onChange={(e) => handleFilterChange("sortBy", e.target.value)}
            />
            Number of Orders
          </RadioButton>
          <RadioButton theme={theme}>
            <input
              type="radio"
              name="sortBy"
              value="date"
              checked={filters.sortBy === "date"}
              onChange={(e) => handleFilterChange("sortBy", e.target.value)}
            />
            Date
          </RadioButton>
        </RadioGroup>
      </Section>{/* Search */}
      <Section>
        <SectionTitle>Search</SectionTitle>
        <SelectInputContainer theme={theme}>
          <select
            value={filters.searchField}
            onChange={(e) => handleFilterChange("searchField", e.target.value)}
          >
            <option value="name">Name</option>
            <option value="email">Email</option>
            <option value="country">Country</option>
            <option value="contact">Contact</option>
            <option value="address">Address</option>
          </select>
          <input
            type="text"
            placeholder={`Search by ${filters.searchField}`}
            value={filters.searchValue}
            onChange={(e) => handleFilterChange("searchValue", e.target.value)}
          />
        </SelectInputContainer>
      </Section>

      {/* Total Spend Range */}
      <Section>
        <SectionTitle>Total Spend Range</SectionTitle>
        <Slider theme={theme}>
          <input
            type="range"
            min="0"
            max="10000"
            value={filters.spendRange[0]}
            onChange={(e) => handleSliderChange("spendRange", 0, e.target.value)}
          />
          <input
            type="range"
            min="0"
            max="10000"
            value={filters.spendRange[1]}
            onChange={(e) => handleSliderChange("spendRange", 1, e.target.value)}
          />
          <div className="range-labels">
            <span>${filters.spendRange[0]}</span>
            <span>${filters.spendRange[1]}</span>
          </div>
        </Slider>
      </Section>

      {/* Total Orders Range */}
      <Section>
        <SectionTitle>Total Orders Range</SectionTitle>
        <Slider theme={theme}>
          <input
            type="range"
            min="0"
            max="100"
            value={filters.orderRange[0]}
            onChange={(e) => handleSliderChange("orderRange", 0, e.target.value)}
          />
          <input
            type="range"
            min="0"
            max="100"
            value={filters.orderRange[1]}
            onChange={(e) => handleSliderChange("orderRange", 1, e.target.value)}
          />
          <div className="range-labels">
            <span>{filters.orderRange[0]}</span>
            <span>{filters.orderRange[1]}</span>
          </div>
        </Slider>
      </Section>

      

      <ApplyButton theme={theme} onClick={applyFilters}>
        Apply Filters
      </ApplyButton>
    </FilterContainer>
  );
};

export default FilterForm;
