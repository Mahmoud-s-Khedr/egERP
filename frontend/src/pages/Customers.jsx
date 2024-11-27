import styled from "styled-components"
import CustomerTable from "../components/CustomersTable";
import FilterFrom from "../components/FilterForm";
import AddCustomer from "../components/AddCutomer";


const PageWrapper=styled.div`
    display: flex;
    flex-direction: row;
    flex-wrap: wrap;
    justify-content: space-between;
    height: 100%;
    width: 100%;
`;
const FilterWrapper=styled.div`
    display: flex;
    flex-direction:row ;
    flex-wrap: wrap;
    width: 25%;
    @media (max-width: 768px) {
        width: 100%;
    }
`;
const TableWrapper=styled.div`
    display: flex;
    flex-direction:column ;
    flex-wrap: wrap;
    background: ${({theme})=>theme.componentBackground};
    width: 74%;
    border: 1px solid #ccc;
    border-radius: 10px;
    box-shadow: rgba(0, 0, 0, 0.35) 0px 5px 15px;
    @media (max-width: 768px) {
        width: 100%;
        margin-top: 10px;

    }
`;



function Customers() {
    return (
        <PageWrapper>
            <FilterWrapper>
              <FilterFrom/>
            </FilterWrapper>
            <TableWrapper>
                
                <CustomerTable/>
            </TableWrapper>
            
        </PageWrapper>
    )
}

export default Customers