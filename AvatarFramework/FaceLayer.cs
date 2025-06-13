using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.AvatarFramework
{
	// Token: 0x0200061D RID: 1565
	[Serializable]
	public class FaceLayer : AvatarLayer
	{
		// Token: 0x06008922 RID: 35106 RVA: 0x00040F69 File Offset: 0x0003F169
		// Note: this type is marked as 'beforefieldinit'.
		static FaceLayer()
		{
			Il2CppClassPointerStore<FaceLayer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.AvatarFramework", "FaceLayer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FaceLayer>.NativeClassPtr);
			FaceLayer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FaceLayer>.NativeClassPtr, 100680513);
		}

		// Token: 0x06008923 RID: 35107 RVA: 0x00245F1C File Offset: 0x0024411C
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 92196, RefRangeEnd = 92208, XrefRangeStart = 92196, XrefRangeEnd = 92208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FaceLayer() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FaceLayer>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FaceLayer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008924 RID: 35108 RVA: 0x00040FA2 File Offset: 0x0003F1A2
		public FaceLayer(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04005D5A RID: 23898
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
