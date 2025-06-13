using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Dialogue
{
	// Token: 0x02000467 RID: 1127
	[System.Serializable]
	public class BranchOptionData : Il2CppSystem.Object
	{
		// Token: 0x0600615A RID: 24922 RVA: 0x001C0CD4 File Offset: 0x001BEED4
		// Note: this type is marked as 'beforefieldinit'.
		static BranchOptionData()
		{
			Il2CppClassPointerStore<BranchOptionData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Dialogue", "BranchOptionData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BranchOptionData>.NativeClassPtr);
			BranchOptionData.NativeFieldInfoPtr_Guid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BranchOptionData>.NativeClassPtr, "Guid");
			BranchOptionData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BranchOptionData>.NativeClassPtr, 100675814);
		}

		// Token: 0x0600615B RID: 24923 RVA: 0x001C0D2C File Offset: 0x001BEF2C
		[CallerCount(2576)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BranchOptionData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BranchOptionData>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BranchOptionData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600615C RID: 24924 RVA: 0x0002DAB4 File Offset: 0x0002BCB4
		public BranchOptionData(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001D05 RID: 7429
		// (get) Token: 0x0600615D RID: 24925 RVA: 0x001C0D68 File Offset: 0x001BEF68
		// (set) Token: 0x0600615E RID: 24926 RVA: 0x0002DABD File Offset: 0x0002BCBD
		public unsafe string Guid
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BranchOptionData.NativeFieldInfoPtr_Guid);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BranchOptionData.NativeFieldInfoPtr_Guid), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04004294 RID: 17044
		private static readonly System.IntPtr NativeFieldInfoPtr_Guid;

		// Token: 0x04004295 RID: 17045
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
