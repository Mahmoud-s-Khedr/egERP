import ProfileHeader from "../Components/ProfileHeader"
import CustomerProfileData from "../Components/CustomerProfileData"
import Table from "../Components/Table"


function CusomerProfile() {
    return (
        <>
            <ProfileHeader/>
            <CustomerProfileData/>
            <Table width={"calc(100% - 24px)"}/>
        </>
    )
}    

export default CusomerProfile