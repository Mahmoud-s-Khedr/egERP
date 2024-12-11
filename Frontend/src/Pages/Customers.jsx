import CustomersTable from "../Components/CustomersTable"
import Filter from "../Components/Filter"


function Customers() {
    return (
        <>
            <Filter/>
            <CustomersTable width={"calc(100% - 24px)"}/>
        </>
    )
}

export default Customers