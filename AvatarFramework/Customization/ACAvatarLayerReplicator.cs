using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.AvatarFramework.Customization
{
	// Token: 0x02000640 RID: 1600
	public class ACAvatarLayerReplicator : ACAssetPathReplicator<AvatarLayer>
	{
		// Token: 0x06008C85 RID: 35973 RVA: 0x00042EB5 File Offset: 0x000410B5
		// Note: this type is marked as 'beforefieldinit'.
		static ACAvatarLayerReplicator()
		{
			Il2CppClassPointerStore<ACAvatarLayerReplicator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.AvatarFramework.Customization", "ACAvatarLayerReplicator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ACAvatarLayerReplicator>.NativeClassPtr);
			ACAvatarLayerReplicator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ACAvatarLayerReplicator>.NativeClassPtr, 100680867);
		}

		// Token: 0x06008C86 RID: 35974 RVA: 0x0024FC58 File Offset: 0x0024DE58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258138, XrefRangeEnd = 258141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ACAvatarLayerReplicator() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ACAvatarLayerReplicator>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ACAvatarLayerReplicator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008C87 RID: 35975 RVA: 0x00042EEE File Offset: 0x000410EE
		public ACAvatarLayerReplicator(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04005F66 RID: 24422
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
