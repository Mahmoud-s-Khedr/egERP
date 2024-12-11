import ProductTable from "../Components/ProductTable";
import Filter from "../Components/Filter";

function Products() {
    return (
        <>
            <Filter/>
            <ProductTable width={"calc(100% - 24px)"}/>
        </>
    )
}

export default Products