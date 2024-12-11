import ProfileHeader from "../Components/ProfileHeader"
import OrderDetails from "../Components/OrderDetails"
import OrderProductData from "../Components/OrderProductData"


function OrderPreview() {
    return (
        <>
            <OrderDetails/>
            <ProfileHeader/>
            <OrderProductData/>
        </>
    )
}

export default OrderPreview