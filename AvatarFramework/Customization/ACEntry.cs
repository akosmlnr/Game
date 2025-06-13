using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.AvatarFramework.Customization
{
	// Token: 0x02000637 RID: 1591
	public class ACEntry : MonoBehaviour
	{
		// Token: 0x06008BA1 RID: 35745 RVA: 0x0024D0CC File Offset: 0x0024B2CC
		// Note: this type is marked as 'beforefieldinit'.
		static ACEntry()
		{
			Il2CppClassPointerStore<ACEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.AvatarFramework.Customization", "ACEntry");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ACEntry>.NativeClassPtr);
			ACEntry.NativeFieldInfoPtr_DevOnly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ACEntry>.NativeClassPtr, "DevOnly");
			ACEntry.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ACEntry>.NativeClassPtr, 100680779);
			ACEntry.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ACEntry>.NativeClassPtr, 100680780);
		}

		// Token: 0x06008BA2 RID: 35746 RVA: 0x0024D138 File Offset: 0x0024B338
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257344, XrefRangeEnd = 257350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ACEntry.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008BA3 RID: 35747 RVA: 0x0024D16C File Offset: 0x0024B36C
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ACEntry() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ACEntry>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ACEntry.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008BA4 RID: 35748 RVA: 0x00042667 File Offset: 0x00040867
		public ACEntry(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002A56 RID: 10838
		// (get) Token: 0x06008BA5 RID: 35749 RVA: 0x0024D1A8 File Offset: 0x0024B3A8
		// (set) Token: 0x06008BA6 RID: 35750 RVA: 0x00042670 File Offset: 0x00040870
		public unsafe bool DevOnly
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ACEntry.NativeFieldInfoPtr_DevOnly);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ACEntry.NativeFieldInfoPtr_DevOnly)) = value;
			}
		}

		// Token: 0x04005ED9 RID: 24281
		private static readonly IntPtr NativeFieldInfoPtr_DevOnly;

		// Token: 0x04005EDA RID: 24282
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04005EDB RID: 24283
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
