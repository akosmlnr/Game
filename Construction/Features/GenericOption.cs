using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Construction.Features
{
	// Token: 0x020004A6 RID: 1190
	public class GenericOption : MonoBehaviour
	{
		// Token: 0x0600663D RID: 26173 RVA: 0x001D0670 File Offset: 0x001CE870
		// Note: this type is marked as 'beforefieldinit'.
		static GenericOption()
		{
			Il2CppClassPointerStore<GenericOption>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Construction.Features", "GenericOption");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GenericOption>.NativeClassPtr);
			GenericOption.NativeFieldInfoPtr_optionName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericOption>.NativeClassPtr, "optionName");
			GenericOption.NativeFieldInfoPtr_optionButtonColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericOption>.NativeClassPtr, "optionButtonColor");
			GenericOption.NativeFieldInfoPtr_optionPrice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericOption>.NativeClassPtr, "optionPrice");
			GenericOption.NativeFieldInfoPtr_onInstalled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericOption>.NativeClassPtr, "onInstalled");
			GenericOption.NativeFieldInfoPtr_onUninstalled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericOption>.NativeClassPtr, "onUninstalled");
			GenericOption.NativeFieldInfoPtr_onSetVisible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericOption>.NativeClassPtr, "onSetVisible");
			GenericOption.NativeFieldInfoPtr_onSetInvisible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericOption>.NativeClassPtr, "onSetInvisible");
			GenericOption.NativeMethodInfoPtr_Install_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericOption>.NativeClassPtr, 100676347);
			GenericOption.NativeMethodInfoPtr_Uninstall_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericOption>.NativeClassPtr, 100676348);
			GenericOption.NativeMethodInfoPtr_SetVisible_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericOption>.NativeClassPtr, 100676349);
			GenericOption.NativeMethodInfoPtr_SetInvisible_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericOption>.NativeClassPtr, 100676350);
			GenericOption.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericOption>.NativeClassPtr, 100676351);
		}

		// Token: 0x0600663E RID: 26174 RVA: 0x001D0790 File Offset: 0x001CE990
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208740, XrefRangeEnd = 208741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Install()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GenericOption.NativeMethodInfoPtr_Install_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600663F RID: 26175 RVA: 0x001D07CC File Offset: 0x001CE9CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208741, XrefRangeEnd = 208742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Uninstall()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GenericOption.NativeMethodInfoPtr_Uninstall_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006640 RID: 26176 RVA: 0x001D0808 File Offset: 0x001CEA08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208742, XrefRangeEnd = 208743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetVisible()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GenericOption.NativeMethodInfoPtr_SetVisible_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006641 RID: 26177 RVA: 0x001D0844 File Offset: 0x001CEA44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetInvisible()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GenericOption.NativeMethodInfoPtr_SetInvisible_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006642 RID: 26178 RVA: 0x001D0880 File Offset: 0x001CEA80
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GenericOption() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GenericOption>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericOption.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006643 RID: 26179 RVA: 0x000301E2 File Offset: 0x0002E3E2
		public GenericOption(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001EA1 RID: 7841
		// (get) Token: 0x06006644 RID: 26180 RVA: 0x001D08BC File Offset: 0x001CEABC
		// (set) Token: 0x06006645 RID: 26181 RVA: 0x000301EB File Offset: 0x0002E3EB
		public unsafe string optionName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericOption.NativeFieldInfoPtr_optionName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericOption.NativeFieldInfoPtr_optionName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001EA2 RID: 7842
		// (get) Token: 0x06006646 RID: 26182 RVA: 0x001D08E4 File Offset: 0x001CEAE4
		// (set) Token: 0x06006647 RID: 26183 RVA: 0x0003020A File Offset: 0x0002E40A
		public unsafe Color optionButtonColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericOption.NativeFieldInfoPtr_optionButtonColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericOption.NativeFieldInfoPtr_optionButtonColor)) = value;
			}
		}

		// Token: 0x17001EA3 RID: 7843
		// (get) Token: 0x06006648 RID: 26184 RVA: 0x001D090C File Offset: 0x001CEB0C
		// (set) Token: 0x06006649 RID: 26185 RVA: 0x00030225 File Offset: 0x0002E425
		public unsafe float optionPrice
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericOption.NativeFieldInfoPtr_optionPrice);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericOption.NativeFieldInfoPtr_optionPrice)) = value;
			}
		}

		// Token: 0x17001EA4 RID: 7844
		// (get) Token: 0x0600664A RID: 26186 RVA: 0x001D0934 File Offset: 0x001CEB34
		// (set) Token: 0x0600664B RID: 26187 RVA: 0x00030240 File Offset: 0x0002E440
		public unsafe UnityEvent onInstalled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericOption.NativeFieldInfoPtr_onInstalled);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericOption.NativeFieldInfoPtr_onInstalled), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EA5 RID: 7845
		// (get) Token: 0x0600664C RID: 26188 RVA: 0x001D0964 File Offset: 0x001CEB64
		// (set) Token: 0x0600664D RID: 26189 RVA: 0x0003025F File Offset: 0x0002E45F
		public unsafe UnityEvent onUninstalled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericOption.NativeFieldInfoPtr_onUninstalled);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericOption.NativeFieldInfoPtr_onUninstalled), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EA6 RID: 7846
		// (get) Token: 0x0600664E RID: 26190 RVA: 0x001D0994 File Offset: 0x001CEB94
		// (set) Token: 0x0600664F RID: 26191 RVA: 0x0003027E File Offset: 0x0002E47E
		public unsafe UnityEvent onSetVisible
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericOption.NativeFieldInfoPtr_onSetVisible);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericOption.NativeFieldInfoPtr_onSetVisible), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EA7 RID: 7847
		// (get) Token: 0x06006650 RID: 26192 RVA: 0x001D09C4 File Offset: 0x001CEBC4
		// (set) Token: 0x06006651 RID: 26193 RVA: 0x0003029D File Offset: 0x0002E49D
		public unsafe UnityEvent onSetInvisible
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericOption.NativeFieldInfoPtr_onSetInvisible);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericOption.NativeFieldInfoPtr_onSetInvisible), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040045C7 RID: 17863
		private static readonly IntPtr NativeFieldInfoPtr_optionName;

		// Token: 0x040045C8 RID: 17864
		private static readonly IntPtr NativeFieldInfoPtr_optionButtonColor;

		// Token: 0x040045C9 RID: 17865
		private static readonly IntPtr NativeFieldInfoPtr_optionPrice;

		// Token: 0x040045CA RID: 17866
		private static readonly IntPtr NativeFieldInfoPtr_onInstalled;

		// Token: 0x040045CB RID: 17867
		private static readonly IntPtr NativeFieldInfoPtr_onUninstalled;

		// Token: 0x040045CC RID: 17868
		private static readonly IntPtr NativeFieldInfoPtr_onSetVisible;

		// Token: 0x040045CD RID: 17869
		private static readonly IntPtr NativeFieldInfoPtr_onSetInvisible;

		// Token: 0x040045CE RID: 17870
		private static readonly IntPtr NativeMethodInfoPtr_Install_Public_Virtual_New_Void_0;

		// Token: 0x040045CF RID: 17871
		private static readonly IntPtr NativeMethodInfoPtr_Uninstall_Public_Virtual_New_Void_0;

		// Token: 0x040045D0 RID: 17872
		private static readonly IntPtr NativeMethodInfoPtr_SetVisible_Public_Virtual_New_Void_0;

		// Token: 0x040045D1 RID: 17873
		private static readonly IntPtr NativeMethodInfoPtr_SetInvisible_Public_Virtual_New_Void_0;

		// Token: 0x040045D2 RID: 17874
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
