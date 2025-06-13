using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Interaction;
using Il2CppScheduleOne.Property;
using Il2CppScheduleOne.UI;
using UnityEngine;

namespace Il2CppScheduleOne.Market
{
	// Token: 0x0200039C RID: 924
	public class BuilderMerchant : MonoBehaviour
	{
		// Token: 0x0600474C RID: 18252 RVA: 0x001600B0 File Offset: 0x0015E2B0
		// Note: this type is marked as 'beforefieldinit'.
		static BuilderMerchant()
		{
			Il2CppClassPointerStore<BuilderMerchant>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Market", "BuilderMerchant");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuilderMerchant>.NativeClassPtr);
			BuilderMerchant.NativeFieldInfoPtr_openTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuilderMerchant>.NativeClassPtr, "openTime");
			BuilderMerchant.NativeFieldInfoPtr_closeTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuilderMerchant>.NativeClassPtr, "closeTime");
			BuilderMerchant.NativeFieldInfoPtr_intObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuilderMerchant>.NativeClassPtr, "intObj");
			BuilderMerchant.NativeFieldInfoPtr_selector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuilderMerchant>.NativeClassPtr, "selector");
			BuilderMerchant.NativeMethodInfoPtr_Hovered_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuilderMerchant>.NativeClassPtr, 100672144);
			BuilderMerchant.NativeMethodInfoPtr_Interacted_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuilderMerchant>.NativeClassPtr, 100672145);
			BuilderMerchant.NativeMethodInfoPtr_PropertySelected_Private_Void_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuilderMerchant>.NativeClassPtr, 100672146);
			BuilderMerchant.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuilderMerchant>.NativeClassPtr, 100672147);
		}

		// Token: 0x0600474D RID: 18253 RVA: 0x00160180 File Offset: 0x0015E380
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162587, XrefRangeEnd = 162602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Hovered()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuilderMerchant.NativeMethodInfoPtr_Hovered_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600474E RID: 18254 RVA: 0x001601B4 File Offset: 0x0015E3B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162602, XrefRangeEnd = 162610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Interacted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuilderMerchant.NativeMethodInfoPtr_Interacted_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600474F RID: 18255 RVA: 0x001601E8 File Offset: 0x0015E3E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162610, XrefRangeEnd = 162616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PropertySelected(Property p)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuilderMerchant.NativeMethodInfoPtr_PropertySelected_Private_Void_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004750 RID: 18256 RVA: 0x0016022C File Offset: 0x0015E42C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162616, XrefRangeEnd = 162617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BuilderMerchant() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BuilderMerchant>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuilderMerchant.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004751 RID: 18257 RVA: 0x00022851 File Offset: 0x00020A51
		public BuilderMerchant(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700155C RID: 5468
		// (get) Token: 0x06004752 RID: 18258 RVA: 0x00160268 File Offset: 0x0015E468
		// (set) Token: 0x06004753 RID: 18259 RVA: 0x0002285A File Offset: 0x00020A5A
		public unsafe int openTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuilderMerchant.NativeFieldInfoPtr_openTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuilderMerchant.NativeFieldInfoPtr_openTime)) = value;
			}
		}

		// Token: 0x1700155D RID: 5469
		// (get) Token: 0x06004754 RID: 18260 RVA: 0x00160290 File Offset: 0x0015E490
		// (set) Token: 0x06004755 RID: 18261 RVA: 0x00022875 File Offset: 0x00020A75
		public unsafe int closeTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuilderMerchant.NativeFieldInfoPtr_closeTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuilderMerchant.NativeFieldInfoPtr_closeTime)) = value;
			}
		}

		// Token: 0x1700155E RID: 5470
		// (get) Token: 0x06004756 RID: 18262 RVA: 0x001602B8 File Offset: 0x0015E4B8
		// (set) Token: 0x06004757 RID: 18263 RVA: 0x00022890 File Offset: 0x00020A90
		public unsafe InteractableObject intObj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuilderMerchant.NativeFieldInfoPtr_intObj);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InteractableObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuilderMerchant.NativeFieldInfoPtr_intObj), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700155F RID: 5471
		// (get) Token: 0x06004758 RID: 18264 RVA: 0x001602E8 File Offset: 0x0015E4E8
		// (set) Token: 0x06004759 RID: 18265 RVA: 0x000228AF File Offset: 0x00020AAF
		public unsafe PropertySelector selector
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuilderMerchant.NativeFieldInfoPtr_selector);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PropertySelector>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuilderMerchant.NativeFieldInfoPtr_selector), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002FD8 RID: 12248
		private static readonly IntPtr NativeFieldInfoPtr_openTime;

		// Token: 0x04002FD9 RID: 12249
		private static readonly IntPtr NativeFieldInfoPtr_closeTime;

		// Token: 0x04002FDA RID: 12250
		private static readonly IntPtr NativeFieldInfoPtr_intObj;

		// Token: 0x04002FDB RID: 12251
		private static readonly IntPtr NativeFieldInfoPtr_selector;

		// Token: 0x04002FDC RID: 12252
		private static readonly IntPtr NativeMethodInfoPtr_Hovered_Public_Void_0;

		// Token: 0x04002FDD RID: 12253
		private static readonly IntPtr NativeMethodInfoPtr_Interacted_Public_Void_0;

		// Token: 0x04002FDE RID: 12254
		private static readonly IntPtr NativeMethodInfoPtr_PropertySelected_Private_Void_Property_0;

		// Token: 0x04002FDF RID: 12255
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
