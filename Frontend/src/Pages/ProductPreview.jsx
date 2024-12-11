import ImageCarsouel from "../Components/ImageCarsouel"
import ProductData from "../Components/ProductData"
import styled from "styled-components"
import useTheme from "../Context/useTheme"
const Container = styled.div`
    display:flex;
    flex-direction: row;
    width: calc(100%);
    gap: 24px;
`
function ProductPreview() {
    const {theme} = useTheme()
    return (
        <Container>
        <ImageCarsouel width="calc(100%/2 - 24px)"/>
        <ProductData/>
        </Container>

    )
}

export default ProductPreview