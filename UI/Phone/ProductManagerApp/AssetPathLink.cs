using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.UI.Phone.ProductManagerApp
{
	// Token: 0x020006CB RID: 1739
	public class AssetPathLink : MonoBehaviour
	{
		// Token: 0x06009ACB RID: 39627 RVA: 0x0027A4F0 File Offset: 0x002786F0
		// Note: this type is marked as 'beforefieldinit'.
		static AssetPathLink()
		{
			Il2CppClassPointerStore<AssetPathLink>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Phone.ProductManagerApp", "AssetPathLink");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssetPathLink>.NativeClassPtr);
			AssetPathLink.NativeFieldInfoPtr_prefabID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetPathLink>.NativeClassPtr, "prefabID");
			AssetPathLink.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetPathLink>.NativeClassPtr, 100682504);
		}

		// Token: 0x06009ACC RID: 39628 RVA: 0x0027A548 File Offset: 0x00278748
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276362, XrefRangeEnd = 276366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AssetPathLink() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AssetPathLink>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetPathLink.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009ACD RID: 39629 RVA: 0x0004B1DB File Offset: 0x000493DB
		public AssetPathLink(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002F53 RID: 12115
		// (get) Token: 0x06009ACE RID: 39630 RVA: 0x0027A584 File Offset: 0x00278784
		// (set) Token: 0x06009ACF RID: 39631 RVA: 0x0004B1E4 File Offset: 0x000493E4
		public unsafe string prefabID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetPathLink.NativeFieldInfoPtr_prefabID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetPathLink.NativeFieldInfoPtr_prefabID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04006849 RID: 26697
		private static readonly IntPtr NativeFieldInfoPtr_prefabID;

		// Token: 0x0400684A RID: 26698
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
