/// <summary>
/// ͼƬת������
/// </summary>
/// <param name="picPath">ͼƬ·��</param>
/// <returns></returns>
private byte[] GetPictureBytes(string picPath)
{
	using (FileStream fs = new FileStream(picPath, FileMode.Open, FileAccess.Read))
	{
		byte[] fileData = new byte[fs.Length];
		fs.Read(fileData, 0, fileData.Length);
		return fileData;
	}
}