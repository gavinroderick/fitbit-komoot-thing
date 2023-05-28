# Untitled Tree Thing API


## Techy Details
> Section to talk a bit about the techy side of this project, what I enjoyed. Mainly a braindump space for me so I can reflect on the project later.

### Things I enjoyed, found notable or am generally happy with

#### Soft Delete / Global Query Filters
https://stackoverflow.com/a/65702479
I've missed using GQF's while I've been in Node land - so was keen to use them again here. Initially I was just going to apply them to each model individually,
but wanted to see if there was a better way to just apply the filter to everything that uses `BaseModel`

Don't think I've ever knowingly used reflection, but apparently this is it. Seems like a nice, neat way to achieve what I want.

#### Exception Handling Middleware
https://code-maze.com/global-error-handling-aspnetcore/
Was fun to write some middleware for the first time in .NET really. This is somewhere I've more experience in JS, feels weird to be porting knowledge back that way.