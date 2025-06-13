using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.AvatarFramework.Customization
{
	// Token: 0x0200063E RID: 1598
	public class ACAccessoryReplicator : ACAssetPathReplicator<Accessory>
	{
		// Token: 0x06008C7B RID: 35963 RVA: 0x00042E4B File Offset: 0x0004104B
		// Note: this type is marked as 'beforefieldinit'.
		static ACAccessoryReplicator()
		{
			Il2CppClassPointerStore<ACAccessoryReplicator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.AvatarFramework.Customization", "ACAccessoryReplicator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ACAccessoryReplicator>.NativeClassPtr);
			ACAccessoryReplicator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ACAccessoryReplicator>.NativeClassPtr, 100680863);
		}

		// Token: 0x06008C7C RID: 35964 RVA: 0x0024FA68 File Offset: 0x0024DC68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258123, XrefRangeEnd = 258126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ACAccessoryReplicator() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ACAccessoryReplicator>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ACAccessoryReplicator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008C7D RID: 35965 RVA: 0x00042E84 File Offset: 0x00041084
		public ACAccessoryReplicator(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04005F61 RID: 24417
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
