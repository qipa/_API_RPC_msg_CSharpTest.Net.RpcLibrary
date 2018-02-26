// --------------------------------------------------------------------------------------------
// Version: MPL 1.1/GPL 2.0/LGPL 2.1
// 
// The contents of this file are subject to the Mozilla Public License Version
// 1.1 (the "License"); you may not use this file except in compliance with
// the License. You may obtain a copy of the License at
// http://www.mozilla.org/MPL/
// 
// Software distributed under the License is distributed on an "AS IS" basis,
// WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License
// for the specific language governing rights and limitations under the
// License.
// 
// <remarks>
// Generated by IDLImporter from file nsIAccessibleRole.idl
// 
// You should use these interfaces when you access the COM objects defined in the mentioned
// IDL/IDH file.
// </remarks>
// --------------------------------------------------------------------------------------------
namespace Gecko
{
	using System;
	using System.Runtime.InteropServices;
	using System.Runtime.InteropServices.ComTypes;
	using System.Runtime.CompilerServices;
	
	
	/// <summary>
    /// Defines cross platform (Gecko) roles.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("50db5e86-9a45-4637-a5c3-4ff148c33270")]
	public interface nsIAccessibleRole
	{
	}
	
	/// <summary>nsIAccessibleRoleConsts </summary>
	public class nsIAccessibleRoleConsts
	{
		
		// <summary>
        // Used when accessible hans't strong defined role.
        // </summary>
		public const ulong ROLE_NOTHING = 0;
		
		// <summary>
        // Represents a title or caption bar for a window. It is used by MSAA only,
        // supported automatically by MS Windows.
        // </summary>
		public const ulong ROLE_TITLEBAR = 1;
		
		// <summary>
        // Represents the menu bar (positioned beneath the title bar of a window)
        // from which menus are selected by the user. The role is used by
        // xul:menubar or role="menubar".
        // </summary>
		public const ulong ROLE_MENUBAR = 2;
		
		// <summary>
        // Represents a vertical or horizontal scroll bar, which is part of the client
        // area or used in a control.
        // </summary>
		public const ulong ROLE_SCROLLBAR = 3;
		
		// <summary>
        // Represents a special mouse pointer, which allows a user to manipulate user
        // interface elements such as windows. For example, a user clicks and drags
        // a sizing grip in the lower-right corner of a window to resize it.
        // </summary>
		public const ulong ROLE_GRIP = 4;
		
		// <summary>
        // Represents a system sound, which is associated with various system events.
        // </summary>
		public const ulong ROLE_SOUND = 5;
		
		// <summary>
        // Represents the system mouse pointer.
        // </summary>
		public const ulong ROLE_CURSOR = 6;
		
		// <summary>
        // Represents the system caret. The role is supported for caret.
        // </summary>
		public const ulong ROLE_CARET = 7;
		
		// <summary>
        // Represents an alert or a condition that a user should be notified about.
        // Assistive Technologies typically respond to the role by reading the entire
        // onscreen contents of containers advertising this role. Should be used for
        // warning dialogs, etc. The role is used by xul:browsermessage,
        // role="alert", xforms:message.
        // </summary>
		public const ulong ROLE_ALERT = 8;
		
		// <summary>
        // Represents the window frame, which contains child objects such as
        // a title bar, client, and other objects contained in a window. The role
        // is supported automatically by MS Windows.
        // </summary>
		public const ulong ROLE_WINDOW = 9;
		
		// <summary>
        // A sub-document (<frame> or <iframe>)
        // </summary>
		public const ulong ROLE_INTERNAL_FRAME = 10;
		
		// <summary>
        // Represents a menu, which presents a list of options from which the user can
        // make a selection to perform an action. It is used for role="menu".
        // </summary>
		public const ulong ROLE_MENUPOPUP = 11;
		
		// <summary>
        // Represents a menu item, which is an entry in a menu that a user can choose
        // to carry out a command, select an option. It is used for xul:menuitem,
        // role="menuitem".
        // </summary>
		public const ulong ROLE_MENUITEM = 12;
		
		// <summary>
        // Represents a ToolTip that provides helpful hints.
        // </summary>
		public const ulong ROLE_TOOLTIP = 13;
		
		// <summary>
        // Represents a main window for an application. It is used for
        // role="application". Also refer to ROLE_APP_ROOT
        // </summary>
		public const ulong ROLE_APPLICATION = 14;
		
		// <summary>
        // Represents a document window. A document window is always contained within
        // an application window. It is used for role="document".
        // </summary>
		public const ulong ROLE_DOCUMENT = 15;
		
		// <summary>
        // Represents a pane within a frame or document window. Users can navigate
        // between panes and within the contents of the current pane, but cannot
        // navigate between items in different panes. Thus, panes represent a level
        // of grouping lower than frame windows or documents, but above individual
        // controls. It is used for the first child of a <frame> or <iframe>.
        // </summary>
		public const ulong ROLE_PANE = 16;
		
		// <summary>
        // Represents a graphical image used to represent data.
        // </summary>
		public const ulong ROLE_CHART = 17;
		
		// <summary>
        // Represents a dialog box or message box. It is used for xul:dialog,
        // role="dialog".
        // </summary>
		public const ulong ROLE_DIALOG = 18;
		
		// <summary>
        // Represents a window border.
        // </summary>
		public const ulong ROLE_BORDER = 19;
		
		// <summary>
        // Logically groups other objects. There is not always a parent-child
        // relationship between the grouping object and the objects it contains. It
        // is used for html:textfield, xul:groupbox, role="group".
        // </summary>
		public const ulong ROLE_GROUPING = 20;
		
		// <summary>
        // Used to visually divide a space into two regions, such as a separator menu
        // item or a bar that divides split panes within a window. It is used for
        // xul:separator, html:hr, role="separator".
        // </summary>
		public const ulong ROLE_SEPARATOR = 21;
		
		// <summary>
        // Represents a toolbar, which is a grouping of controls (push buttons or
        // toggle buttons) that provides easy access to frequently used features. It
        // is used for xul:toolbar, role="toolbar".
        // </summary>
		public const ulong ROLE_TOOLBAR = 22;
		
		// <summary>
        // Represents a status bar, which is an area at the bottom of a window that
        // displays information about the current operation, state of the application,
        // or selected object. The status bar has multiple fields, which display
        // different kinds of information. It is used for xul:statusbar.
        // </summary>
		public const ulong ROLE_STATUSBAR = 23;
		
		// <summary>
        // Represents a table that contains rows and columns of cells, and optionally,
        // row headers and column headers. It is used for html:table,
        // role="grid". Also refer to the following roles: ROLE_COLUMNHEADER,
        // ROLE_ROWHEADER, ROLE_COLUMN, ROLE_ROW, ROLE_CELL.
        // </summary>
		public const ulong ROLE_TABLE = 24;
		
		// <summary>
        // Represents a column header, providing a visual label for a column in
        // a table. It is used for XUL tree column headers, html:th,
        // role="colheader". Also refer to ROLE_TABLE.
        // </summary>
		public const ulong ROLE_COLUMNHEADER = 25;
		
		// <summary>
        // Represents a row header, which provides a visual label for a table row.
        // It is used for role="rowheader". Also, see ROLE_TABLE.
        // </summary>
		public const ulong ROLE_ROWHEADER = 26;
		
		// <summary>
        // Represents a column of cells within a table. Also, see ROLE_TABLE.
        // </summary>
		public const ulong ROLE_COLUMN = 27;
		
		// <summary>
        // Represents a row of cells within a table. Also, see ROLE_TABLE.
        // </summary>
		public const ulong ROLE_ROW = 28;
		
		// <summary>
        // Represents a cell within a table. It is used for html:td,
        // xul:tree cell and xul:listcell. Also, see ROLE_TABLE.
        // </summary>
		public const ulong ROLE_CELL = 29;
		
		// <summary>
        // Represents a link to something else. This object might look like text or
        // a graphic, but it acts like a button. It is used for
        // xul:label@class="text-link", html:a, html:area,
        // xforms:trigger@appearance="minimal".
        // </summary>
		public const ulong ROLE_LINK = 30;
		
		// <summary>
        // Displays a Help topic in the form of a ToolTip or Help balloon.
        // </summary>
		public const ulong ROLE_HELPBALLOON = 31;
		
		// <summary>
        // Represents a cartoon-like graphic object, such as Microsoft Office
        // Assistant, which is displayed to provide help to users of an application.
        // </summary>
		public const ulong ROLE_CHARACTER = 32;
		
		// <summary>
        // Represents a list box, allowing the user to select one or more items. It
        // is used for xul:listbox, html:select@size, role="list". See also
        // ROLE_LIST_ITEM.
        // </summary>
		public const ulong ROLE_LIST = 33;
		
		// <summary>
        // Represents an item in a list. See also ROLE_LIST.
        // </summary>
		public const ulong ROLE_LISTITEM = 34;
		
		// <summary>
        // Represents an outline or tree structure, such as a tree view control,
        // that displays a hierarchical list and allows the user to expand and
        // collapse branches. Is is used for role="tree".
        // </summary>
		public const ulong ROLE_OUTLINE = 35;
		
		// <summary>
        // Represents an item in an outline or tree structure. It is used for
        // role="treeitem".
        // </summary>
		public const ulong ROLE_OUTLINEITEM = 36;
		
		// <summary>
        // Represents a page tab, it is a child of a page tab list. It is used for
        // xul:tab, role="treeitem". Also refer to ROLE_PAGETABLIST.
        // </summary>
		public const ulong ROLE_PAGETAB = 37;
		
		// <summary>
        // Represents a property sheet. It is used for xul:tabpanel,
        // role="tabpanel".
        // </summary>
		public const ulong ROLE_PROPERTYPAGE = 38;
		
		// <summary>
        // Represents an indicator, such as a pointer graphic, that points to the
        // current item.
        // </summary>
		public const ulong ROLE_INDICATOR = 39;
		
		// <summary>
        // Represents a picture. Is is used for xul:image, html:img.
        // </summary>
		public const ulong ROLE_GRAPHIC = 40;
		
		// <summary>
        // Represents read-only text, such as labels for other controls or
        // instructions in a dialog box. Static text cannot be modified or selected.
        // Is is used for xul:label, xul:description, html:label, role="label",
        // or xforms:output.
        // </summary>
		public const ulong ROLE_STATICTEXT = 41;
		
		// <summary>
        // Represents selectable text that allows edits or is designated read-only.
        // </summary>
		public const ulong ROLE_TEXT_LEAF = 42;
		
		// <summary>
        // Represents a push button control. It is used for xul:button, html:button,
        // role="button", xforms:trigger, xforms:submit.
        // </summary>
		public const ulong ROLE_PUSHBUTTON = 43;
		
		// <summary>
        // Represents a check box control. It is used for xul:checkbox,
        // html:input@type="checkbox", role="checkbox", boolean xforms:input.
        // </summary>
		public const ulong ROLE_CHECKBUTTON = 44;
		
		// <summary>
        // Represents an option button, also called a radio button. It is one of a
        // group of mutually exclusive options. All objects sharing a single parent
        // that have this attribute are assumed to be part of single mutually
        // exclusive group. It is used for xul:radio, html:input@type="radio",
        // role="radio".
        // </summary>
		public const ulong ROLE_RADIOBUTTON = 45;
		
		// <summary>
        // Represents a combo box; an edit control with an associated list box that
        // provides a set of predefined choices. It is used for html:select,
        // xul:menulist, role="combobox".
        // </summary>
		public const ulong ROLE_COMBOBOX = 46;
		
		// <summary>
        // Represents the calendar control. It is used for date xforms:input.
        // </summary>
		public const ulong ROLE_DROPLIST = 47;
		
		// <summary>
        // Represents a progress bar, dynamically showing the user the percent
        // complete of an operation in progress. It is used for xul:progressmeter,
        // role="progressbar".
        // </summary>
		public const ulong ROLE_PROGRESSBAR = 48;
		
		// <summary>
        // Represents a dial or knob whose purpose is to allow a user to set a value.
        // </summary>
		public const ulong ROLE_DIAL = 49;
		
		// <summary>
        // Represents a hot-key field that allows the user to enter a combination or
        // sequence of keystrokes.
        // </summary>
		public const ulong ROLE_HOTKEYFIELD = 50;
		
		// <summary>
        // Represents a slider, which allows the user to adjust a setting in given
        // increments between minimum and maximum values. It is used by xul:scale,
        // role="slider", xforms:range.
        // </summary>
		public const ulong ROLE_SLIDER = 51;
		
		// <summary>
        // Represents a spin box, which is a control that allows the user to increment
        // or decrement the value displayed in a separate "buddy" control associated
        // with the spin box. It is used for xul:spinbuttons.
        // </summary>
		public const ulong ROLE_SPINBUTTON = 52;
		
		// <summary>
        // Represents a graphical image used to diagram data. It is used for svg:svg.
        // </summary>
		public const ulong ROLE_DIAGRAM = 53;
		
		// <summary>
        // Represents an animation control, which contains content that changes over
        // time, such as a control that displays a series of bitmap frames.
        // </summary>
		public const ulong ROLE_ANIMATION = 54;
		
		// <summary>
        // Represents a mathematical equation. It is used by MATHML, where there is a
        // rich DOM subtree for an equation. Use ROLE_FLAT_EQUATION for <img role="math" alt="[TeX]"/>
        // </summary>
		public const ulong ROLE_EQUATION = 55;
		
		// <summary>
        // Represents a button that drops down a list of items.
        // </summary>
		public const ulong ROLE_BUTTONDROPDOWN = 56;
		
		// <summary>
        // Represents a button that drops down a menu.
        // </summary>
		public const ulong ROLE_BUTTONMENU = 57;
		
		// <summary>
        // Represents a button that drops down a grid. It is used for xul:colorpicker.
        // </summary>
		public const ulong ROLE_BUTTONDROPDOWNGRID = 58;
		
		// <summary>
        // Represents blank space between other objects.
        // </summary>
		public const ulong ROLE_WHITESPACE = 59;
		
		// <summary>
        // Represents a container of page tab controls. Is it used for xul:tabs,
        // DHTML: role="tabs". Also refer to ROLE_PAGETAB.
        // </summary>
		public const ulong ROLE_PAGETABLIST = 60;
		
		// <summary>
        // Represents a control that displays time.
        // </summary>
		public const ulong ROLE_CLOCK = 61;
		
		// <summary>
        // Represents a button on a toolbar that has a drop-down list icon directly
        // adjacent to the button.
        // </summary>
		public const ulong ROLE_SPLITBUTTON = 62;
		
		// <summary>
        // Represents an edit control designed for an Internet Protocol (IP) address.
        // The edit control is divided into sections for the different parts of the
        // IP address.
        // </summary>
		public const ulong ROLE_IPADDRESS = 63;
		
		// <summary>
        // Represents a label control that has an accelerator.
        // </summary>
		public const ulong ROLE_ACCEL_LABEL = 64;
		
		// <summary>
        // Represents an arrow in one of the four cardinal directions.
        // </summary>
		public const ulong ROLE_ARROW = 65;
		
		// <summary>
        // Represents a control that can be drawn into and is used to trap events.
        // It is used for html:canvas.
        // </summary>
		public const ulong ROLE_CANVAS = 66;
		
		// <summary>
        // Represents a menu item with a check box.
        // </summary>
		public const ulong ROLE_CHECK_MENU_ITEM = 67;
		
		// <summary>
        // Represents a specialized dialog that lets the user choose a color.
        // </summary>
		public const ulong ROLE_COLOR_CHOOSER = 68;
		
		// <summary>
        // Represents control whose purpose is to allow a user to edit a date.
        // </summary>
		public const ulong ROLE_DATE_EDITOR = 69;
		
		// <summary>
        // An iconified internal frame in an ROLE_DESKTOP_PANE. Also refer to
        // ROLE_INTERNAL_FRAME.
        // </summary>
		public const ulong ROLE_DESKTOP_ICON = 70;
		
		// <summary>
        // A desktop pane. A pane that supports internal frames and iconified
        // versions of those internal frames.
        // </summary>
		public const ulong ROLE_DESKTOP_FRAME = 71;
		
		// <summary>
        // A directory pane. A pane that allows the user to navigate through
        // and select the contents of a directory. May be used by a file chooser.
        // Also refer to ROLE_FILE_CHOOSER.
        // </summary>
		public const ulong ROLE_DIRECTORY_PANE = 72;
		
		// <summary>
        // A file chooser. A specialized dialog that displays the files in the
        // directory and lets the user select a file, browse a different directory,
        // or specify a filename. May use the directory pane to show the contents of
        // a directory. Also refer to ROLE_DIRECTORY_PANE.
        // </summary>
		public const ulong ROLE_FILE_CHOOSER = 73;
		
		// <summary>
        // A font chooser. A font chooser is a component that lets the user pick
        // various attributes for fonts.
        // </summary>
		public const ulong ROLE_FONT_CHOOSER = 74;
		
		// <summary>
        // Frame role. A top level window with a title bar, border, menu bar, etc.
        // It is often used as the primary window for an application.
        // </summary>
		public const ulong ROLE_CHROME_WINDOW = 75;
		
		// <summary>
        // A glass pane. A pane that is guaranteed to be painted on top of all
        // panes beneath it. Also refer to ROLE_ROOT_PANE.
        // </summary>
		public const ulong ROLE_GLASS_PANE = 76;
		
		// <summary>
        // A document container for HTML, whose children represent the document
        // content.
        // </summary>
		public const ulong ROLE_HTML_CONTAINER = 77;
		
		// <summary>
        // A small fixed size picture, typically used to decorate components.
        // </summary>
		public const ulong ROLE_ICON = 78;
		
		// <summary>
        // Presents an icon or short string in an interface.
        // </summary>
		public const ulong ROLE_LABEL = 79;
		
		// <summary>
        // A layered pane. A specialized pane that allows its children to be drawn
        // in layers, providing a form of stacking order. This is usually the pane
        // that holds the menu bar as  well as the pane that contains most of the
        // visual components in a window. Also refer to ROLE_GLASS_PANE and
        // ROLE_ROOT_PANE.
        // </summary>
		public const ulong ROLE_LAYERED_PANE = 80;
		
		// <summary>
        // A specialized pane whose primary use is inside a dialog.
        // </summary>
		public const ulong ROLE_OPTION_PANE = 81;
		
		// <summary>
        // A text object uses for passwords, or other places where the text content
        // is not shown visibly to the user.
        // </summary>
		public const ulong ROLE_PASSWORD_TEXT = 82;
		
		// <summary>
        // A temporary window that is usually used to offer the user a list of
        // choices, and then hides when the user selects one of those choices.
        // </summary>
		public const ulong ROLE_POPUP_MENU = 83;
		
		// <summary>
        // A radio button that is a menu item.
        // </summary>
		public const ulong ROLE_RADIO_MENU_ITEM = 84;
		
		// <summary>
        // A root pane. A specialized pane that has a glass pane and a layered pane
        // as its children. Also refer to ROLE_GLASS_PANE and ROLE_LAYERED_PANE.
        // </summary>
		public const ulong ROLE_ROOT_PANE = 85;
		
		// <summary>
        // A scroll pane. An object that allows a user to incrementally view a large
        // amount of information.  Its children can include scroll bars and a
        // viewport. Also refer to ROLE_VIEW_PORT.
        // </summary>
		public const ulong ROLE_SCROLL_PANE = 86;
		
		// <summary>
        // A split pane. A specialized panel that presents two other panels at the
        // same time. Between the two panels is a divider the user can manipulate to
        // make one panel larger and the other panel smaller.
        // </summary>
		public const ulong ROLE_SPLIT_PANE = 87;
		
		// <summary>
        // The header for a column of a table.
        // XXX: it looks this role is dupe of ROLE_COLUMNHEADER.
        // </summary>
		public const ulong ROLE_TABLE_COLUMN_HEADER = 88;
		
		// <summary>
        // The header for a row of a table.
        // XXX: it looks this role is dupe of ROLE_ROWHEADER
        // </summary>
		public const ulong ROLE_TABLE_ROW_HEADER = 89;
		
		// <summary>
        // A menu item used to tear off and reattach its menu.
        // </summary>
		public const ulong ROLE_TEAR_OFF_MENU_ITEM = 90;
		
		// <summary>
        // Represents an accessible terminal.
        // </summary>
		public const ulong ROLE_TERMINAL = 91;
		
		// <summary>
        // Collection of objects that constitute a logical text entity.
        // </summary>
		public const ulong ROLE_TEXT_CONTAINER = 92;
		
		// <summary>
        // A toggle button. A specialized push button that can be checked or
        // unchecked, but does not provide a separate indicator for the current state.
        // </summary>
		public const ulong ROLE_TOGGLE_BUTTON = 93;
		
		// <summary>
        // Representas a control that is capable of expanding and collapsing rows as
        // well as showing multiple columns of data.
        // XXX: it looks like this role is dupe of ROLE_OUTLINE.
        // </summary>
		public const ulong ROLE_TREE_TABLE = 94;
		
		// <summary>
        // A viewport. An object usually used in a scroll pane. It represents the
        // portion of the entire data that the user can see. As the user manipulates
        // the scroll bars, the contents of the viewport can change. Also refer to
        // ROLE_SCROLL_PANE.
        // </summary>
		public const ulong ROLE_VIEWPORT = 95;
		
		// <summary>
        // Header of a document page. Also refer to ROLE_FOOTER.
        // </summary>
		public const ulong ROLE_HEADER = 96;
		
		// <summary>
        // Footer of a document page. Also refer to ROLE_HEADER.
        // </summary>
		public const ulong ROLE_FOOTER = 97;
		
		// <summary>
        // A paragraph of text.
        // </summary>
		public const ulong ROLE_PARAGRAPH = 98;
		
		// <summary>
        // A ruler such as those used in word processors.
        // </summary>
		public const ulong ROLE_RULER = 99;
		
		// <summary>
        // A text entry having dialog or list containing items for insertion into
        // an entry widget, for instance a list of words for completion of a
        // text entry. It is used for xul:textbox@autocomplete
        // </summary>
		public const ulong ROLE_AUTOCOMPLETE = 100;
		
		// <summary>
        // An editable text object in a toolbar.
        // </summary>
		public const ulong ROLE_EDITBAR = 101;
		
		// <summary>
        // An control whose textual content may be entered or modified by the user.
        // </summary>
		public const ulong ROLE_ENTRY = 102;
		
		// <summary>
        // A caption describing another object.
        // </summary>
		public const ulong ROLE_CAPTION = 103;
		
		// <summary>
        // A visual frame or container which contains a view of document content.
        // Document frames may occur within another Document instance, in which case
        // the second document may be said to be embedded in the containing instance.
        // HTML frames are often ROLE_DOCUMENT_FRAME. Either this object, or a
        // singleton descendant, should implement the Document interface.
        // </summary>
		public const ulong ROLE_DOCUMENT_FRAME = 104;
		
		// <summary>
        // Heading.
        // </summary>
		public const ulong ROLE_HEADING = 105;
		
		// <summary>
        // An object representing a page of document content.  It is used in documents
        // which are accessed by the user on a page by page basis.
        // </summary>
		public const ulong ROLE_PAGE = 106;
		
		// <summary>
        // A container of document content.  An example of the use of this role is to
        // represent an html:div.
        // </summary>
		public const ulong ROLE_SECTION = 107;
		
		// <summary>
        // An object which is redundant with another object in the accessible
        // hierarchy. ATs typically ignore objects with this role.
        // </summary>
		public const ulong ROLE_REDUNDANT_OBJECT = 108;
		
		// <summary>
        // A container of form controls. An example of the use of this role is to
        // represent an html:form.
        // </summary>
		public const ulong ROLE_FORM = 109;
		
		// <summary>
        // An object which is used to allow input of characters not found on a
        // keyboard, such as the input of Chinese characters on a Western keyboard.
        // </summary>
		public const ulong ROLE_IME = 110;
		
		// <summary>
        // XXX: document this.
        // </summary>
		public const ulong ROLE_APP_ROOT = 111;
		
		// <summary>
        // Represents a menu item, which is an entry in a menu that a user can choose
        // to display another menu.
        // </summary>
		public const ulong ROLE_PARENT_MENUITEM = 112;
		
		// <summary>
        // A calendar that allows the user to select a date.
        // </summary>
		public const ulong ROLE_CALENDAR = 113;
		
		// <summary>
        // A list of items that is shown by combobox.
        // </summary>
		public const ulong ROLE_COMBOBOX_LIST = 114;
		
		// <summary>
        // A item of list that is shown by combobox;
        // </summary>
		public const ulong ROLE_COMBOBOX_OPTION = 115;
		
		// <summary>
        // An image map -- has child links representing the areas
        // </summary>
		public const ulong ROLE_IMAGE_MAP = 116;
		
		// <summary>
        // An option in a listbox
        // </summary>
		public const ulong ROLE_OPTION = 117;
		
		// <summary>
        // A rich option in a listbox, it can have other widgets as children
        // </summary>
		public const ulong ROLE_RICH_OPTION = 118;
		
		// <summary>
        // A list of options
        // </summary>
		public const ulong ROLE_LISTBOX = 119;
		
		// <summary>
        // Represents a mathematical equation in the accessible name
        // </summary>
		public const ulong ROLE_FLAT_EQUATION = 120;
		
		// <summary>
        // Represents a cell within a grid. It is used for role="gridcell". Unlike
        // ROLE_CELL, it allows the calculation of the accessible name from subtree.
        // Also, see ROLE_TABLE.
        // </summary>
		public const ulong ROLE_GRID_CELL = 121;
		
		// <summary>
        // Represents an embedded object. It is used for html:object or html:embed.
        // </summary>
		public const ulong ROLE_EMBEDDED_OBJECT = 122;
		
		// <summary>
        // A note. Originally intended to be hidden until activated, but now also used
        // for things like html 'aside'.
        // </summary>
		public const ulong ROLE_NOTE = 123;
		
		// <summary>
        // A figure. Used for things like HTML5 figure element.
        // </summary>
		public const ulong ROLE_FIGURE = 124;
		
		// <summary>
        // Represents a rich item with a check box.
        // </summary>
		public const ulong ROLE_CHECK_RICH_OPTION = 125;
		
		// <summary>
        // An HTML definition list <dl>
        // </summary>
		public const ulong ROLE_DEFINITION_LIST = 126;
		
		// <summary>
        // An HTML definition term <dt>
        // </summary>
		public const ulong ROLE_TERM = 127;
		
		// <summary>
        // An HTML definition <dd>
        // </summary>
		public const ulong ROLE_DEFINITION = 128;
	}
}
