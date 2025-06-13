using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Tiles
{
	// Token: 0x020001A7 RID: 423
	public class IndoorTile : Tile
	{
		// Token: 0x06002267 RID: 8807 RVA: 0x0001310E File Offset: 0x0001130E
		// Note: this type is marked as 'beforefieldinit'.
		static IndoorTile()
		{
			Il2CppClassPointerStore<IndoorTile>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tiles", "IndoorTile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IndoorTile>.NativeClassPtr);
			IndoorTile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndoorTile>.NativeClassPtr, 100667222);
		}

		// Token: 0x06002268 RID: 8808 RVA: 0x000DF154 File Offset: 0x000DD354
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114528, XrefRangeEnd = 114553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IndoorTile() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IndoorTile>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IndoorTile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002269 RID: 8809 RVA: 0x00013147 File Offset: 0x00011347
		public IndoorTile(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040016E5 RID: 5861
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
