using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x0200066B RID: 1643
	public class ItemSelectorButtonLink : MonoBehaviour
	{
		// Token: 0x0600907A RID: 36986 RVA: 0x00045308 File Offset: 0x00043508
		// Note: this type is marked as 'beforefieldinit'.
		static ItemSelectorButtonLink()
		{
			Il2CppClassPointerStore<ItemSelectorButtonLink>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "ItemSelectorButtonLink");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemSelectorButtonLink>.NativeClassPtr);
			ItemSelectorButtonLink.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSelectorButtonLink>.NativeClassPtr, 100681332);
		}

		// Token: 0x0600907B RID: 36987 RVA: 0x0025B910 File Offset: 0x00259B10
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemSelectorButtonLink() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemSelectorButtonLink>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSelectorButtonLink.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600907C RID: 36988 RVA: 0x00045341 File Offset: 0x00043541
		public ItemSelectorButtonLink(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040061DB RID: 25051
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
