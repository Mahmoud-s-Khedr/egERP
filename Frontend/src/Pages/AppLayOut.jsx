
import  SideBar  from '../Components/SideBar'
import TextControlExample from '../Components/TextControlsExample'
export default function AppLayOut() {
    return (
        <div className='container-fluid d-flex p-0'>
            <SideBar/>
            <div className="col-10">
              <TextControlExample/>
            </div>
        </div>
    )
}