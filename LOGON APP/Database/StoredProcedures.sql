--		   CRUD OPERATIONS WITH NOTES
-- =============================================
-- CREATE/ADD
-- =============================================
CREATE PROCEDURE AddNote
	@NoteContent NVARCHAR(MAX),
	@UserId INT
AS
BEGIN
	SET NOCOUNT ON;
	INSERT INTO Notes (Content, UserId) 
	VALUES (@NoteContent, @UserId)
END
GO
-- =============================================
-- READ/GET
-- =============================================
CREATE PROCEDURE GetNotesByUser
	@UserId INT
AS
BEGIN
	SELECT Id, Content
	FROM Notes
	WHERE UserId = @UserId
END
GO
-- =============================================
-- UPDATE
-- =============================================
CREATE PROCEDURE UpdateNote
	@NoteId INT,
	@UserId INT,
	@Content NVARCHAR(MAX)
AS
BEGIN
	UPDATE Notes
	SET Content = @Content
	WHERE Id = @NoteId AND UserId = @UserId
END
GO
-- =============================================
-- DELETE
-- =============================================
CREATE PROCEDURE DeleteNote
	@UserId INT,
	@NoteId INT
AS
BEGIN
	DELETE FROM Notes 
	WHERE UserId = @UserId 
	AND Id = @NoteId
END
GO
