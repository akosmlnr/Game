using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ConstructableScripts;
using Il2CppScheduleOne.Construction.Features;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.UI.Construction.Features;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;

namespace Il2CppScheduleOne.UI.Construction
{
	// Token: 0x0200074B RID: 1867
	public class FeaturesManager : Singleton<FeaturesManager>
	{
		// Token: 0x0600A775 RID: 42869 RVA: 0x002A11B4 File Offset: 0x0029F3B4
		// Note: this type is marked as 'beforefieldinit'.
		static FeaturesManager()
		{
			Il2CppClassPointerStore<FeaturesManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Construction", "FeaturesManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FeaturesManager>.NativeClassPtr);
			FeaturesManager.NativeFieldInfoPtr_activeConstructable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FeaturesManager>.NativeClassPtr, "activeConstructable");
			FeaturesManager.NativeFieldInfoPtr_selectedFeature = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FeaturesManager>.NativeClassPtr, "selectedFeature");
			FeaturesManager.NativeFieldInfoPtr_featureIconsContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FeaturesManager>.NativeClassPtr, "featureIconsContainer");
			FeaturesManager.NativeFieldInfoPtr_featureMenuRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FeaturesManager>.NativeClassPtr, "featureMenuRect");
			FeaturesManager.NativeFieldInfoPtr_featureMenuTitleLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FeaturesManager>.NativeClassPtr, "featureMenuTitleLabel");
			FeaturesManager.NativeFieldInfoPtr_featureInterfaceContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FeaturesManager>.NativeClassPtr, "featureInterfaceContainer");
			FeaturesManager.NativeFieldInfoPtr_featureIconPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FeaturesManager>.NativeClassPtr, "featureIconPrefab");
			FeaturesManager.NativeFieldInfoPtr_currentFeatureInterface = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FeaturesManager>.NativeClassPtr, "currentFeatureInterface");
			FeaturesManager.NativeFieldInfoPtr_roofSetInvisible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FeaturesManager>.NativeClassPtr, "roofSetInvisible");
			FeaturesManager.NativeFieldInfoPtr_featureIcons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FeaturesManager>.NativeClassPtr, "featureIcons");
			FeaturesManager.NativeMethodInfoPtr_get_isActive_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeaturesManager>.NativeClassPtr, 100683867);
			FeaturesManager.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeaturesManager>.NativeClassPtr, 100683868);
			FeaturesManager.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeaturesManager>.NativeClassPtr, 100683869);
			FeaturesManager.NativeMethodInfoPtr_OpenFeatureMenu_Public_Void_Feature_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeaturesManager>.NativeClassPtr, 100683870);
			FeaturesManager.NativeMethodInfoPtr_CloseFeatureMenu_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeaturesManager>.NativeClassPtr, 100683871);
			FeaturesManager.NativeMethodInfoPtr_DeselectFeature_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeaturesManager>.NativeClassPtr, 100683872);
			FeaturesManager.NativeMethodInfoPtr_Activate_Public_Void_Constructable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeaturesManager>.NativeClassPtr, 100683873);
			FeaturesManager.NativeMethodInfoPtr_Deactivate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeaturesManager>.NativeClassPtr, 100683874);
			FeaturesManager.NativeMethodInfoPtr_ClearIcons_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeaturesManager>.NativeClassPtr, 100683875);
			FeaturesManager.NativeMethodInfoPtr_CreateIcons_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeaturesManager>.NativeClassPtr, 100683876);
			FeaturesManager.NativeMethodInfoPtr_UpdateIconTransforms_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeaturesManager>.NativeClassPtr, 100683877);
			FeaturesManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeaturesManager>.NativeClassPtr, 100683878);
		}

		// Token: 0x17003381 RID: 13185
		// (get) Token: 0x0600A776 RID: 42870 RVA: 0x002A139C File Offset: 0x0029F59C
		public unsafe bool isActive
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292635, XrefRangeEnd = 292639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(FeaturesManager.NativeMethodInfoPtr_get_isActive_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x0600A777 RID: 42871 RVA: 0x002A13D8 File Offset: 0x0029F5D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292639, XrefRangeEnd = 292643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FeaturesManager.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A778 RID: 42872 RVA: 0x002A1414 File Offset: 0x0029F614
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292643, XrefRangeEnd = 292649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FeaturesManager.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A779 RID: 42873 RVA: 0x002A1448 File Offset: 0x0029F648
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 292674, RefRangeEnd = 292675, XrefRangeStart = 292649, XrefRangeEnd = 292674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OpenFeatureMenu(Feature feature)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(feature);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FeaturesManager.NativeMethodInfoPtr_OpenFeatureMenu_Public_Void_Feature_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A77A RID: 42874 RVA: 0x002A148C File Offset: 0x0029F68C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 292692, RefRangeEnd = 292697, XrefRangeStart = 292675, XrefRangeEnd = 292692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CloseFeatureMenu()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FeaturesManager.NativeMethodInfoPtr_CloseFeatureMenu_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A77B RID: 42875 RVA: 0x002A14C0 File Offset: 0x0029F6C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292697, XrefRangeEnd = 292718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DeselectFeature()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FeaturesManager.NativeMethodInfoPtr_DeselectFeature_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A77C RID: 42876 RVA: 0x002A14F4 File Offset: 0x0029F6F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292718, XrefRangeEnd = 292721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Activate(Constructable constructable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(constructable);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FeaturesManager.NativeMethodInfoPtr_Activate_Public_Void_Constructable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A77D RID: 42877 RVA: 0x002A1538 File Offset: 0x0029F738
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 292740, RefRangeEnd = 292743, XrefRangeStart = 292721, XrefRangeEnd = 292740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Deactivate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FeaturesManager.NativeMethodInfoPtr_Deactivate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A77E RID: 42878 RVA: 0x002A156C File Offset: 0x0029F76C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292743, XrefRangeEnd = 292755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearIcons()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FeaturesManager.NativeMethodInfoPtr_ClearIcons_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A77F RID: 42879 RVA: 0x002A15A0 File Offset: 0x0029F7A0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 292788, RefRangeEnd = 292790, XrefRangeStart = 292755, XrefRangeEnd = 292788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateIcons()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FeaturesManager.NativeMethodInfoPtr_CreateIcons_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A780 RID: 42880 RVA: 0x002A15D4 File Offset: 0x0029F7D4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 292805, RefRangeEnd = 292807, XrefRangeStart = 292790, XrefRangeEnd = 292805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateIconTransforms()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FeaturesManager.NativeMethodInfoPtr_UpdateIconTransforms_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A781 RID: 42881 RVA: 0x002A1608 File Offset: 0x0029F808
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292807, XrefRangeEnd = 292817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FeaturesManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FeaturesManager>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FeaturesManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A782 RID: 42882 RVA: 0x00052551 File Offset: 0x00050751
		public FeaturesManager(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003377 RID: 13175
		// (get) Token: 0x0600A783 RID: 42883 RVA: 0x002A1644 File Offset: 0x0029F844
		// (set) Token: 0x0600A784 RID: 42884 RVA: 0x0005255A File Offset: 0x0005075A
		public unsafe Constructable activeConstructable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeaturesManager.NativeFieldInfoPtr_activeConstructable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Constructable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeaturesManager.NativeFieldInfoPtr_activeConstructable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003378 RID: 13176
		// (get) Token: 0x0600A785 RID: 42885 RVA: 0x002A1674 File Offset: 0x0029F874
		// (set) Token: 0x0600A786 RID: 42886 RVA: 0x00052579 File Offset: 0x00050779
		public unsafe Feature selectedFeature
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeaturesManager.NativeFieldInfoPtr_selectedFeature);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Feature>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeaturesManager.NativeFieldInfoPtr_selectedFeature), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003379 RID: 13177
		// (get) Token: 0x0600A787 RID: 42887 RVA: 0x002A16A4 File Offset: 0x0029F8A4
		// (set) Token: 0x0600A788 RID: 42888 RVA: 0x00052598 File Offset: 0x00050798
		public unsafe RectTransform featureIconsContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeaturesManager.NativeFieldInfoPtr_featureIconsContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeaturesManager.NativeFieldInfoPtr_featureIconsContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700337A RID: 13178
		// (get) Token: 0x0600A789 RID: 42889 RVA: 0x002A16D4 File Offset: 0x0029F8D4
		// (set) Token: 0x0600A78A RID: 42890 RVA: 0x000525B7 File Offset: 0x000507B7
		public unsafe RectTransform featureMenuRect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeaturesManager.NativeFieldInfoPtr_featureMenuRect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeaturesManager.NativeFieldInfoPtr_featureMenuRect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700337B RID: 13179
		// (get) Token: 0x0600A78B RID: 42891 RVA: 0x002A1704 File Offset: 0x0029F904
		// (set) Token: 0x0600A78C RID: 42892 RVA: 0x000525D6 File Offset: 0x000507D6
		public unsafe TextMeshProUGUI featureMenuTitleLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeaturesManager.NativeFieldInfoPtr_featureMenuTitleLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeaturesManager.NativeFieldInfoPtr_featureMenuTitleLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700337C RID: 13180
		// (get) Token: 0x0600A78D RID: 42893 RVA: 0x002A1734 File Offset: 0x0029F934
		// (set) Token: 0x0600A78E RID: 42894 RVA: 0x000525F5 File Offset: 0x000507F5
		public unsafe RectTransform featureInterfaceContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeaturesManager.NativeFieldInfoPtr_featureInterfaceContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeaturesManager.NativeFieldInfoPtr_featureInterfaceContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700337D RID: 13181
		// (get) Token: 0x0600A78F RID: 42895 RVA: 0x002A1764 File Offset: 0x0029F964
		// (set) Token: 0x0600A790 RID: 42896 RVA: 0x00052614 File Offset: 0x00050814
		public unsafe GameObject featureIconPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeaturesManager.NativeFieldInfoPtr_featureIconPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeaturesManager.NativeFieldInfoPtr_featureIconPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700337E RID: 13182
		// (get) Token: 0x0600A791 RID: 42897 RVA: 0x002A1794 File Offset: 0x0029F994
		// (set) Token: 0x0600A792 RID: 42898 RVA: 0x00052633 File Offset: 0x00050833
		public unsafe FI_Base currentFeatureInterface
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeaturesManager.NativeFieldInfoPtr_currentFeatureInterface);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FI_Base>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeaturesManager.NativeFieldInfoPtr_currentFeatureInterface), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700337F RID: 13183
		// (get) Token: 0x0600A793 RID: 42899 RVA: 0x002A17C4 File Offset: 0x0029F9C4
		// (set) Token: 0x0600A794 RID: 42900 RVA: 0x00052652 File Offset: 0x00050852
		public unsafe bool roofSetInvisible
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeaturesManager.NativeFieldInfoPtr_roofSetInvisible);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeaturesManager.NativeFieldInfoPtr_roofSetInvisible)) = value;
			}
		}

		// Token: 0x17003380 RID: 13184
		// (get) Token: 0x0600A795 RID: 42901 RVA: 0x002A17EC File Offset: 0x0029F9EC
		// (set) Token: 0x0600A796 RID: 42902 RVA: 0x0005266D File Offset: 0x0005086D
		public unsafe List<FeatureIcon> featureIcons
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeaturesManager.NativeFieldInfoPtr_featureIcons);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<FeatureIcon>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeaturesManager.NativeFieldInfoPtr_featureIcons), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04007048 RID: 28744
		private static readonly IntPtr NativeFieldInfoPtr_activeConstructable;

		// Token: 0x04007049 RID: 28745
		private static readonly IntPtr NativeFieldInfoPtr_selectedFeature;

		// Token: 0x0400704A RID: 28746
		private static readonly IntPtr NativeFieldInfoPtr_featureIconsContainer;

		// Token: 0x0400704B RID: 28747
		private static readonly IntPtr NativeFieldInfoPtr_featureMenuRect;

		// Token: 0x0400704C RID: 28748
		private static readonly IntPtr NativeFieldInfoPtr_featureMenuTitleLabel;

		// Token: 0x0400704D RID: 28749
		private static readonly IntPtr NativeFieldInfoPtr_featureInterfaceContainer;

		// Token: 0x0400704E RID: 28750
		private static readonly IntPtr NativeFieldInfoPtr_featureIconPrefab;

		// Token: 0x0400704F RID: 28751
		private static readonly IntPtr NativeFieldInfoPtr_currentFeatureInterface;

		// Token: 0x04007050 RID: 28752
		private static readonly IntPtr NativeFieldInfoPtr_roofSetInvisible;

		// Token: 0x04007051 RID: 28753
		private static readonly IntPtr NativeFieldInfoPtr_featureIcons;

		// Token: 0x04007052 RID: 28754
		private static readonly IntPtr NativeMethodInfoPtr_get_isActive_Public_get_Boolean_0;

		// Token: 0x04007053 RID: 28755
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04007054 RID: 28756
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x04007055 RID: 28757
		private static readonly IntPtr NativeMethodInfoPtr_OpenFeatureMenu_Public_Void_Feature_0;

		// Token: 0x04007056 RID: 28758
		private static readonly IntPtr NativeMethodInfoPtr_CloseFeatureMenu_Public_Void_0;

		// Token: 0x04007057 RID: 28759
		private static readonly IntPtr NativeMethodInfoPtr_DeselectFeature_Public_Void_0;

		// Token: 0x04007058 RID: 28760
		private static readonly IntPtr NativeMethodInfoPtr_Activate_Public_Void_Constructable_0;

		// Token: 0x04007059 RID: 28761
		private static readonly IntPtr NativeMethodInfoPtr_Deactivate_Public_Void_0;

		// Token: 0x0400705A RID: 28762
		private static readonly IntPtr NativeMethodInfoPtr_ClearIcons_Private_Void_0;

		// Token: 0x0400705B RID: 28763
		private static readonly IntPtr NativeMethodInfoPtr_CreateIcons_Private_Void_0;

		// Token: 0x0400705C RID: 28764
		private static readonly IntPtr NativeMethodInfoPtr_UpdateIconTransforms_Private_Void_0;

		// Token: 0x0400705D RID: 28765
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
