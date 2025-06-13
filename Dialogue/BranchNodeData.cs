using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Dialogue
{
	// Token: 0x02000466 RID: 1126
	[System.Serializable]
	public class BranchNodeData : Il2CppSystem.Object
	{
		// Token: 0x0600614F RID: 24911 RVA: 0x001C0B5C File Offset: 0x001BED5C
		// Note: this type is marked as 'beforefieldinit'.
		static BranchNodeData()
		{
			Il2CppClassPointerStore<BranchNodeData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Dialogue", "BranchNodeData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BranchNodeData>.NativeClassPtr);
			BranchNodeData.NativeFieldInfoPtr_Guid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BranchNodeData>.NativeClassPtr, "Guid");
			BranchNodeData.NativeFieldInfoPtr_BranchLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BranchNodeData>.NativeClassPtr, "BranchLabel");
			BranchNodeData.NativeFieldInfoPtr_Position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BranchNodeData>.NativeClassPtr, "Position");
			BranchNodeData.NativeFieldInfoPtr_options = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BranchNodeData>.NativeClassPtr, "options");
			BranchNodeData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BranchNodeData>.NativeClassPtr, 100675813);
		}

		// Token: 0x06006150 RID: 24912 RVA: 0x001C0BF0 File Offset: 0x001BEDF0
		[CallerCount(2576)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BranchNodeData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BranchNodeData>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BranchNodeData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006151 RID: 24913 RVA: 0x0002DA33 File Offset: 0x0002BC33
		public BranchNodeData(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001D01 RID: 7425
		// (get) Token: 0x06006152 RID: 24914 RVA: 0x001C0C2C File Offset: 0x001BEE2C
		// (set) Token: 0x06006153 RID: 24915 RVA: 0x0002DA3C File Offset: 0x0002BC3C
		public unsafe string Guid
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BranchNodeData.NativeFieldInfoPtr_Guid);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BranchNodeData.NativeFieldInfoPtr_Guid), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001D02 RID: 7426
		// (get) Token: 0x06006154 RID: 24916 RVA: 0x001C0C54 File Offset: 0x001BEE54
		// (set) Token: 0x06006155 RID: 24917 RVA: 0x0002DA5B File Offset: 0x0002BC5B
		public unsafe string BranchLabel
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BranchNodeData.NativeFieldInfoPtr_BranchLabel);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BranchNodeData.NativeFieldInfoPtr_BranchLabel), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001D03 RID: 7427
		// (get) Token: 0x06006156 RID: 24918 RVA: 0x001C0C7C File Offset: 0x001BEE7C
		// (set) Token: 0x06006157 RID: 24919 RVA: 0x0002DA7A File Offset: 0x0002BC7A
		public unsafe Vector2 Position
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BranchNodeData.NativeFieldInfoPtr_Position);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BranchNodeData.NativeFieldInfoPtr_Position)) = value;
			}
		}

		// Token: 0x17001D04 RID: 7428
		// (get) Token: 0x06006158 RID: 24920 RVA: 0x001C0CA4 File Offset: 0x001BEEA4
		// (set) Token: 0x06006159 RID: 24921 RVA: 0x0002DA95 File Offset: 0x0002BC95
		public unsafe Il2CppReferenceArray<BranchOptionData> options
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BranchNodeData.NativeFieldInfoPtr_options);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<BranchOptionData>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BranchNodeData.NativeFieldInfoPtr_options), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400428F RID: 17039
		private static readonly System.IntPtr NativeFieldInfoPtr_Guid;

		// Token: 0x04004290 RID: 17040
		private static readonly System.IntPtr NativeFieldInfoPtr_BranchLabel;

		// Token: 0x04004291 RID: 17041
		private static readonly System.IntPtr NativeFieldInfoPtr_Position;

		// Token: 0x04004292 RID: 17042
		private static readonly System.IntPtr NativeFieldInfoPtr_options;

		// Token: 0x04004293 RID: 17043
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
