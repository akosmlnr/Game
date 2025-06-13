using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.AvatarFramework.Customization
{
	// Token: 0x02000642 RID: 1602
	public class ACFaceLayerReplicator : ACAssetPathReplicator<FaceLayer>
	{
		// Token: 0x06008C8E RID: 35982 RVA: 0x00042F1F File Offset: 0x0004111F
		// Note: this type is marked as 'beforefieldinit'.
		static ACFaceLayerReplicator()
		{
			Il2CppClassPointerStore<ACFaceLayerReplicator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.AvatarFramework.Customization", "ACFaceLayerReplicator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ACFaceLayerReplicator>.NativeClassPtr);
			ACFaceLayerReplicator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ACFaceLayerReplicator>.NativeClassPtr, 100680870);
		}

		// Token: 0x06008C8F RID: 35983 RVA: 0x0024FDBC File Offset: 0x0024DFBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258151, XrefRangeEnd = 258154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ACFaceLayerReplicator() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ACFaceLayerReplicator>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ACFaceLayerReplicator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008C90 RID: 35984 RVA: 0x00042F58 File Offset: 0x00041158
		public ACFaceLayerReplicator(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04005F6A RID: 24426
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
