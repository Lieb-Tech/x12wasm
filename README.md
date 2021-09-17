# x12wasm

Manually opening and reading  x12 formatted files can be tricky. 
- Many times there's no line breaks, so you have scroll through looking for the line terminators and insert a break manually. This is not back for an 1 item order, but if there are many items, this can be time consuming.
- Or if you want to highlight something in the contents to another person, takes some time to visually find it, and highlight it

x12wasm is a project to try to ease that process - in addition to be a Blazor Wasm learning project.

Project Functionality
- Drag drop one or more files onto the page - and each will open in it's own "tab"
- Mouse over highlighting - makes the data visually standout from the many field terminators
- Mouse over details - shows information about the segment in a details pane, include descriptions for the segment
- If the field is code enumeration, the details pane will list other possible values, and the accompanying description

Project aspects
- As mentioned this Blazor Wasm project, so all the logic run on the browser - no need for a server, other than to host the files.
- The core logic to parse the file is a seperate C# class library, which is also used in my x12winui project. 
- Follows the MVVM pattern.
- Items on the page are broken into Razor components for re-use and clean code
- 
