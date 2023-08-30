DECLARE @NewImage VARBINARY(MAX);
SELECT @NewImage = BulkColumn
FROM OPENROWSET(BULK 'C:\Users\ACER\Desktop\desk tos\pexels-tima-miroshnichenko-7567529.jpg', SINGLE_BLOB) AS img;

DECLARE @ExistingImage VARBINARY(MAX);
SELECT @ExistingImage = [SpaceImage]
FROM [RentalSpace]
WHERE RentalSpaceID = 3;

-- Concatenate the new image data with the existing image data
DECLARE @CombinedImage VARBINARY(MAX);
SET @CombinedImage = @ExistingImage + @NewImage;

UPDATE [RentalSpace]
SET [SpaceImage] = @CombinedImage
WHERE RentalSpaceID = 2;
