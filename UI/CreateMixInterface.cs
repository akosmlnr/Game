using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Product;
using Il2CppScheduleOne.Properties;
using Il2CppScheduleOne.Storage;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000652 RID: 1618
	public class CreateMixInterface : Singleton<CreateMixInterface>
	{
		// Token: 0x06008DAD RID: 36269 RVA: 0x00253158 File Offset: 0x00251358
		// Note: this type is marked as 'beforefieldinit'.
		static CreateMixInterface()
		{
			Il2CppClassPointerStore<CreateMixInterface>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "CreateMixInterface");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CreateMixInterface>.NativeClassPtr);
			CreateMixInterface.NativeFieldInfoPtr_BEAN_REQUIREMENT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateMixInterface>.NativeClassPtr, "BEAN_REQUIREMENT");
			CreateMixInterface.NativeFieldInfoPtr__IsOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateMixInterface>.NativeClassPtr, "<IsOpen>k__BackingField");
			CreateMixInterface.NativeFieldInfoPtr_Canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateMixInterface>.NativeClassPtr, "Canvas");
			CreateMixInterface.NativeFieldInfoPtr_BeansSlot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateMixInterface>.NativeClassPtr, "BeansSlot");
			CreateMixInterface.NativeFieldInfoPtr_ProductSlot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateMixInterface>.NativeClassPtr, "ProductSlot");
			CreateMixInterface.NativeFieldInfoPtr_MixerSlot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateMixInterface>.NativeClassPtr, "MixerSlot");
			CreateMixInterface.NativeFieldInfoPtr_OutputSlot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateMixInterface>.NativeClassPtr, "OutputSlot");
			CreateMixInterface.NativeFieldInfoPtr_OutputIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateMixInterface>.NativeClassPtr, "OutputIcon");
			CreateMixInterface.NativeFieldInfoPtr_BeginButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateMixInterface>.NativeClassPtr, "BeginButton");
			CreateMixInterface.NativeFieldInfoPtr_Storage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateMixInterface>.NativeClassPtr, "Storage");
			CreateMixInterface.NativeFieldInfoPtr_ProductPropertiesLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateMixInterface>.NativeClassPtr, "ProductPropertiesLabel");
			CreateMixInterface.NativeFieldInfoPtr_OutputPropertiesLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateMixInterface>.NativeClassPtr, "OutputPropertiesLabel");
			CreateMixInterface.NativeFieldInfoPtr_BeanProblemLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateMixInterface>.NativeClassPtr, "BeanProblemLabel");
			CreateMixInterface.NativeFieldInfoPtr_ProductProblemLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateMixInterface>.NativeClassPtr, "ProductProblemLabel");
			CreateMixInterface.NativeFieldInfoPtr_MixerProblemLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateMixInterface>.NativeClassPtr, "MixerProblemLabel");
			CreateMixInterface.NativeFieldInfoPtr_OutputProblemLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateMixInterface>.NativeClassPtr, "OutputProblemLabel");
			CreateMixInterface.NativeFieldInfoPtr_CameraPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateMixInterface>.NativeClassPtr, "CameraPosition");
			CreateMixInterface.NativeFieldInfoPtr_UnknownOutputIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateMixInterface>.NativeClassPtr, "UnknownOutputIcon");
			CreateMixInterface.NativeFieldInfoPtr_onOpen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateMixInterface>.NativeClassPtr, "onOpen");
			CreateMixInterface.NativeFieldInfoPtr_onClose = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateMixInterface>.NativeClassPtr, "onClose");
			CreateMixInterface.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateMixInterface>.NativeClassPtr, 100680997);
			CreateMixInterface.NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateMixInterface>.NativeClassPtr, 100680998);
			CreateMixInterface.NativeMethodInfoPtr_get_beanSlot_Private_get_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateMixInterface>.NativeClassPtr, 100680999);
			CreateMixInterface.NativeMethodInfoPtr_get_mixerSlot_Private_get_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateMixInterface>.NativeClassPtr, 100681000);
			CreateMixInterface.NativeMethodInfoPtr_get_outputSlot_Private_get_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateMixInterface>.NativeClassPtr, 100681001);
			CreateMixInterface.NativeMethodInfoPtr_get_productSlot_Private_get_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateMixInterface>.NativeClassPtr, 100681002);
			CreateMixInterface.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateMixInterface>.NativeClassPtr, 100681003);
			CreateMixInterface.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateMixInterface>.NativeClassPtr, 100681004);
			CreateMixInterface.NativeMethodInfoPtr_Open_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateMixInterface>.NativeClassPtr, 100681005);
			CreateMixInterface.NativeMethodInfoPtr_ContentsChanged_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateMixInterface>.NativeClassPtr, 100681006);
			CreateMixInterface.NativeMethodInfoPtr_UpdateCanBegin_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateMixInterface>.NativeClassPtr, 100681007);
			CreateMixInterface.NativeMethodInfoPtr_UpdateOutput_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateMixInterface>.NativeClassPtr, 100681008);
			CreateMixInterface.NativeMethodInfoPtr_BeginPressed_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateMixInterface>.NativeClassPtr, 100681009);
			CreateMixInterface.NativeMethodInfoPtr_GetOutputProperties_Private_List_1_Property_ProductDefinition_PropertyItemDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateMixInterface>.NativeClassPtr, 100681010);
			CreateMixInterface.NativeMethodInfoPtr_IsOutputKnown_Private_Boolean_byref_ProductDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateMixInterface>.NativeClassPtr, 100681011);
			CreateMixInterface.NativeMethodInfoPtr_GetPropertyListString_Private_String_List_1_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateMixInterface>.NativeClassPtr, 100681012);
			CreateMixInterface.NativeMethodInfoPtr_GetPropertyString_Private_String_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateMixInterface>.NativeClassPtr, 100681013);
			CreateMixInterface.NativeMethodInfoPtr_CanBegin_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateMixInterface>.NativeClassPtr, 100681014);
			CreateMixInterface.NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateMixInterface>.NativeClassPtr, 100681015);
			CreateMixInterface.NativeMethodInfoPtr_HasProduct_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateMixInterface>.NativeClassPtr, 100681016);
			CreateMixInterface.NativeMethodInfoPtr_HasBeans_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateMixInterface>.NativeClassPtr, 100681017);
			CreateMixInterface.NativeMethodInfoPtr_HasMixer_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateMixInterface>.NativeClassPtr, 100681018);
			CreateMixInterface.NativeMethodInfoPtr_GetProduct_Private_ProductDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateMixInterface>.NativeClassPtr, 100681019);
			CreateMixInterface.NativeMethodInfoPtr_GetMixer_Private_PropertyItemDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateMixInterface>.NativeClassPtr, 100681020);
			CreateMixInterface.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateMixInterface>.NativeClassPtr, 100681021);
		}

		// Token: 0x17002B0E RID: 11022
		// (get) Token: 0x06008DAE RID: 36270 RVA: 0x0025350C File Offset: 0x0025170C
		// (set) Token: 0x06008DAF RID: 36271 RVA: 0x00253548 File Offset: 0x00251748
		public unsafe bool IsOpen
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(CreateMixInterface.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(19)]
			[CachedScanResults(RefRangeStart = 40119, RefRangeEnd = 40138, XrefRangeStart = 40119, XrefRangeEnd = 40138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreateMixInterface.NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17002B0F RID: 11023
		// (get) Token: 0x06008DB0 RID: 36272 RVA: 0x00253588 File Offset: 0x00251788
		public unsafe ItemSlot beanSlot
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 259184, XrefRangeEnd = 259188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreateMixInterface.NativeMethodInfoPtr_get_beanSlot_Private_get_ItemSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSlot>(intPtr2) : null;
			}
		}

		// Token: 0x17002B10 RID: 11024
		// (get) Token: 0x06008DB1 RID: 36273 RVA: 0x002535C8 File Offset: 0x002517C8
		public unsafe ItemSlot mixerSlot
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 259188, XrefRangeEnd = 259192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreateMixInterface.NativeMethodInfoPtr_get_mixerSlot_Private_get_ItemSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSlot>(intPtr2) : null;
			}
		}

		// Token: 0x17002B11 RID: 11025
		// (get) Token: 0x06008DB2 RID: 36274 RVA: 0x00253608 File Offset: 0x00251808
		public unsafe ItemSlot outputSlot
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 259192, XrefRangeEnd = 259196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreateMixInterface.NativeMethodInfoPtr_get_outputSlot_Private_get_ItemSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSlot>(intPtr2) : null;
			}
		}

		// Token: 0x17002B12 RID: 11026
		// (get) Token: 0x06008DB3 RID: 36275 RVA: 0x00253648 File Offset: 0x00251848
		public unsafe ItemSlot productSlot
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 259196, XrefRangeEnd = 259200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreateMixInterface.NativeMethodInfoPtr_get_productSlot_Private_get_ItemSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSlot>(intPtr2) : null;
			}
		}

		// Token: 0x06008DB4 RID: 36276 RVA: 0x00253688 File Offset: 0x00251888
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 259200, XrefRangeEnd = 259284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CreateMixInterface.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008DB5 RID: 36277 RVA: 0x002536C4 File Offset: 0x002518C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 259284, XrefRangeEnd = 259286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Exit(ExitAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreateMixInterface.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008DB6 RID: 36278 RVA: 0x00253708 File Offset: 0x00251908
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 259384, RefRangeEnd = 259385, XrefRangeStart = 259286, XrefRangeEnd = 259384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreateMixInterface.NativeMethodInfoPtr_Open_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008DB7 RID: 36279 RVA: 0x0025373C File Offset: 0x0025193C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 259385, XrefRangeEnd = 259387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ContentsChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreateMixInterface.NativeMethodInfoPtr_ContentsChanged_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008DB8 RID: 36280 RVA: 0x00253770 File Offset: 0x00251970
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 259431, RefRangeEnd = 259433, XrefRangeStart = 259387, XrefRangeEnd = 259431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateCanBegin()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreateMixInterface.NativeMethodInfoPtr_UpdateCanBegin_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008DB9 RID: 36281 RVA: 0x002537A4 File Offset: 0x002519A4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 259523, RefRangeEnd = 259525, XrefRangeStart = 259433, XrefRangeEnd = 259523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateOutput()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreateMixInterface.NativeMethodInfoPtr_UpdateOutput_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008DBA RID: 36282 RVA: 0x002537D8 File Offset: 0x002519D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 259525, XrefRangeEnd = 259550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BeginPressed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreateMixInterface.NativeMethodInfoPtr_BeginPressed_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008DBB RID: 36283 RVA: 0x0025380C File Offset: 0x00251A0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 259550, XrefRangeEnd = 259556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<Property> GetOutputProperties(ProductDefinition product, PropertyItemDefinition mixer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(product);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(mixer);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreateMixInterface.NativeMethodInfoPtr_GetOutputProperties_Private_List_1_Property_ProductDefinition_PropertyItemDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Property>>(intPtr2) : null;
		}

		// Token: 0x06008DBC RID: 36284 RVA: 0x00253870 File Offset: 0x00251A70
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 259583, RefRangeEnd = 259584, XrefRangeStart = 259556, XrefRangeEnd = 259583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsOutputKnown(out ProductDefinition knownProduct)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(CreateMixInterface.NativeMethodInfoPtr_IsOutputKnown_Private_Boolean_byref_ProductDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			knownProduct = ((intPtr2 == 0) ? null : new ProductDefinition(intPtr2));
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06008DBD RID: 36285 RVA: 0x002538D0 File Offset: 0x00251AD0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 259597, RefRangeEnd = 259599, XrefRangeStart = 259584, XrefRangeEnd = 259597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetPropertyListString(List<Property> properties)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(properties);
			IntPtr returnedException;
			IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(CreateMixInterface.NativeMethodInfoPtr_GetPropertyListString_Private_String_List_1_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}

		// Token: 0x06008DBE RID: 36286 RVA: 0x00253918 File Offset: 0x00251B18
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 259617, RefRangeEnd = 259619, XrefRangeStart = 259599, XrefRangeEnd = 259617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetPropertyString(Property property)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(property);
			IntPtr returnedException;
			IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(CreateMixInterface.NativeMethodInfoPtr_GetPropertyString_Private_String_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}

		// Token: 0x06008DBF RID: 36287 RVA: 0x00253960 File Offset: 0x00251B60
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 259634, RefRangeEnd = 259636, XrefRangeStart = 259619, XrefRangeEnd = 259634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanBegin()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(CreateMixInterface.NativeMethodInfoPtr_CanBegin_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06008DC0 RID: 36288 RVA: 0x0025399C File Offset: 0x00251B9C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 259732, RefRangeEnd = 259734, XrefRangeStart = 259636, XrefRangeEnd = 259732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreateMixInterface.NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008DC1 RID: 36289 RVA: 0x002539D0 File Offset: 0x00251BD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 259734, XrefRangeEnd = 259739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasProduct()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(CreateMixInterface.NativeMethodInfoPtr_HasProduct_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06008DC2 RID: 36290 RVA: 0x00253A0C File Offset: 0x00251C0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 259739, XrefRangeEnd = 259743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasBeans()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(CreateMixInterface.NativeMethodInfoPtr_HasBeans_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06008DC3 RID: 36291 RVA: 0x00253A48 File Offset: 0x00251C48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 259743, XrefRangeEnd = 259748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasMixer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(CreateMixInterface.NativeMethodInfoPtr_HasMixer_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06008DC4 RID: 36292 RVA: 0x00253A84 File Offset: 0x00251C84
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 259752, RefRangeEnd = 259759, XrefRangeStart = 259748, XrefRangeEnd = 259752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProductDefinition GetProduct()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreateMixInterface.NativeMethodInfoPtr_GetProduct_Private_ProductDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProductDefinition>(intPtr2) : null;
		}

		// Token: 0x06008DC5 RID: 36293 RVA: 0x00253AC4 File Offset: 0x00251CC4
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 259779, RefRangeEnd = 259785, XrefRangeStart = 259759, XrefRangeEnd = 259779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PropertyItemDefinition GetMixer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreateMixInterface.NativeMethodInfoPtr_GetMixer_Private_PropertyItemDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<PropertyItemDefinition>(intPtr2) : null;
		}

		// Token: 0x06008DC6 RID: 36294 RVA: 0x00253B04 File Offset: 0x00251D04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 259785, XrefRangeEnd = 259788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CreateMixInterface() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CreateMixInterface>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreateMixInterface.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008DC7 RID: 36295 RVA: 0x00043900 File Offset: 0x00041B00
		public CreateMixInterface(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002AFA RID: 11002
		// (get) Token: 0x06008DC8 RID: 36296 RVA: 0x00253B40 File Offset: 0x00251D40
		// (set) Token: 0x06008DC9 RID: 36297 RVA: 0x00043909 File Offset: 0x00041B09
		public unsafe static int BEAN_REQUIREMENT
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(CreateMixInterface.NativeFieldInfoPtr_BEAN_REQUIREMENT, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CreateMixInterface.NativeFieldInfoPtr_BEAN_REQUIREMENT, (void*)(&value));
			}
		}

		// Token: 0x17002AFB RID: 11003
		// (get) Token: 0x06008DCA RID: 36298 RVA: 0x00253B5C File Offset: 0x00251D5C
		// (set) Token: 0x06008DCB RID: 36299 RVA: 0x00043917 File Offset: 0x00041B17
		public unsafe bool _IsOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateMixInterface.NativeFieldInfoPtr__IsOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateMixInterface.NativeFieldInfoPtr__IsOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x17002AFC RID: 11004
		// (get) Token: 0x06008DCC RID: 36300 RVA: 0x00253B84 File Offset: 0x00251D84
		// (set) Token: 0x06008DCD RID: 36301 RVA: 0x00043932 File Offset: 0x00041B32
		public unsafe Canvas Canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateMixInterface.NativeFieldInfoPtr_Canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateMixInterface.NativeFieldInfoPtr_Canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002AFD RID: 11005
		// (get) Token: 0x06008DCE RID: 36302 RVA: 0x00253BB4 File Offset: 0x00251DB4
		// (set) Token: 0x06008DCF RID: 36303 RVA: 0x00043951 File Offset: 0x00041B51
		public unsafe ItemSlotUI BeansSlot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateMixInterface.NativeFieldInfoPtr_BeansSlot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSlotUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateMixInterface.NativeFieldInfoPtr_BeansSlot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002AFE RID: 11006
		// (get) Token: 0x06008DD0 RID: 36304 RVA: 0x00253BE4 File Offset: 0x00251DE4
		// (set) Token: 0x06008DD1 RID: 36305 RVA: 0x00043970 File Offset: 0x00041B70
		public unsafe ItemSlotUI ProductSlot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateMixInterface.NativeFieldInfoPtr_ProductSlot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSlotUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateMixInterface.NativeFieldInfoPtr_ProductSlot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002AFF RID: 11007
		// (get) Token: 0x06008DD2 RID: 36306 RVA: 0x00253C14 File Offset: 0x00251E14
		// (set) Token: 0x06008DD3 RID: 36307 RVA: 0x0004398F File Offset: 0x00041B8F
		public unsafe ItemSlotUI MixerSlot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateMixInterface.NativeFieldInfoPtr_MixerSlot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSlotUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateMixInterface.NativeFieldInfoPtr_MixerSlot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B00 RID: 11008
		// (get) Token: 0x06008DD4 RID: 36308 RVA: 0x00253C44 File Offset: 0x00251E44
		// (set) Token: 0x06008DD5 RID: 36309 RVA: 0x000439AE File Offset: 0x00041BAE
		public unsafe ItemSlotUI OutputSlot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateMixInterface.NativeFieldInfoPtr_OutputSlot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSlotUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateMixInterface.NativeFieldInfoPtr_OutputSlot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B01 RID: 11009
		// (get) Token: 0x06008DD6 RID: 36310 RVA: 0x00253C74 File Offset: 0x00251E74
		// (set) Token: 0x06008DD7 RID: 36311 RVA: 0x000439CD File Offset: 0x00041BCD
		public unsafe Image OutputIcon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateMixInterface.NativeFieldInfoPtr_OutputIcon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateMixInterface.NativeFieldInfoPtr_OutputIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B02 RID: 11010
		// (get) Token: 0x06008DD8 RID: 36312 RVA: 0x00253CA4 File Offset: 0x00251EA4
		// (set) Token: 0x06008DD9 RID: 36313 RVA: 0x000439EC File Offset: 0x00041BEC
		public unsafe Button BeginButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateMixInterface.NativeFieldInfoPtr_BeginButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateMixInterface.NativeFieldInfoPtr_BeginButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B03 RID: 11011
		// (get) Token: 0x06008DDA RID: 36314 RVA: 0x00253CD4 File Offset: 0x00251ED4
		// (set) Token: 0x06008DDB RID: 36315 RVA: 0x00043A0B File Offset: 0x00041C0B
		public unsafe WorldStorageEntity Storage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateMixInterface.NativeFieldInfoPtr_Storage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WorldStorageEntity>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateMixInterface.NativeFieldInfoPtr_Storage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B04 RID: 11012
		// (get) Token: 0x06008DDC RID: 36316 RVA: 0x00253D04 File Offset: 0x00251F04
		// (set) Token: 0x06008DDD RID: 36317 RVA: 0x00043A2A File Offset: 0x00041C2A
		public unsafe TextMeshProUGUI ProductPropertiesLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateMixInterface.NativeFieldInfoPtr_ProductPropertiesLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateMixInterface.NativeFieldInfoPtr_ProductPropertiesLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B05 RID: 11013
		// (get) Token: 0x06008DDE RID: 36318 RVA: 0x00253D34 File Offset: 0x00251F34
		// (set) Token: 0x06008DDF RID: 36319 RVA: 0x00043A49 File Offset: 0x00041C49
		public unsafe TextMeshProUGUI OutputPropertiesLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateMixInterface.NativeFieldInfoPtr_OutputPropertiesLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateMixInterface.NativeFieldInfoPtr_OutputPropertiesLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B06 RID: 11014
		// (get) Token: 0x06008DE0 RID: 36320 RVA: 0x00253D64 File Offset: 0x00251F64
		// (set) Token: 0x06008DE1 RID: 36321 RVA: 0x00043A68 File Offset: 0x00041C68
		public unsafe TextMeshProUGUI BeanProblemLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateMixInterface.NativeFieldInfoPtr_BeanProblemLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateMixInterface.NativeFieldInfoPtr_BeanProblemLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B07 RID: 11015
		// (get) Token: 0x06008DE2 RID: 36322 RVA: 0x00253D94 File Offset: 0x00251F94
		// (set) Token: 0x06008DE3 RID: 36323 RVA: 0x00043A87 File Offset: 0x00041C87
		public unsafe TextMeshProUGUI ProductProblemLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateMixInterface.NativeFieldInfoPtr_ProductProblemLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateMixInterface.NativeFieldInfoPtr_ProductProblemLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B08 RID: 11016
		// (get) Token: 0x06008DE4 RID: 36324 RVA: 0x00253DC4 File Offset: 0x00251FC4
		// (set) Token: 0x06008DE5 RID: 36325 RVA: 0x00043AA6 File Offset: 0x00041CA6
		public unsafe TextMeshProUGUI MixerProblemLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateMixInterface.NativeFieldInfoPtr_MixerProblemLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateMixInterface.NativeFieldInfoPtr_MixerProblemLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B09 RID: 11017
		// (get) Token: 0x06008DE6 RID: 36326 RVA: 0x00253DF4 File Offset: 0x00251FF4
		// (set) Token: 0x06008DE7 RID: 36327 RVA: 0x00043AC5 File Offset: 0x00041CC5
		public unsafe TextMeshProUGUI OutputProblemLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateMixInterface.NativeFieldInfoPtr_OutputProblemLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateMixInterface.NativeFieldInfoPtr_OutputProblemLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B0A RID: 11018
		// (get) Token: 0x06008DE8 RID: 36328 RVA: 0x00253E24 File Offset: 0x00252024
		// (set) Token: 0x06008DE9 RID: 36329 RVA: 0x00043AE4 File Offset: 0x00041CE4
		public unsafe Transform CameraPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateMixInterface.NativeFieldInfoPtr_CameraPosition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateMixInterface.NativeFieldInfoPtr_CameraPosition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B0B RID: 11019
		// (get) Token: 0x06008DEA RID: 36330 RVA: 0x00253E54 File Offset: 0x00252054
		// (set) Token: 0x06008DEB RID: 36331 RVA: 0x00043B03 File Offset: 0x00041D03
		public unsafe RectTransform UnknownOutputIcon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateMixInterface.NativeFieldInfoPtr_UnknownOutputIcon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateMixInterface.NativeFieldInfoPtr_UnknownOutputIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B0C RID: 11020
		// (get) Token: 0x06008DEC RID: 36332 RVA: 0x00253E84 File Offset: 0x00252084
		// (set) Token: 0x06008DED RID: 36333 RVA: 0x00043B22 File Offset: 0x00041D22
		public unsafe UnityEvent onOpen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateMixInterface.NativeFieldInfoPtr_onOpen);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateMixInterface.NativeFieldInfoPtr_onOpen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B0D RID: 11021
		// (get) Token: 0x06008DEE RID: 36334 RVA: 0x00253EB4 File Offset: 0x002520B4
		// (set) Token: 0x06008DEF RID: 36335 RVA: 0x00043B41 File Offset: 0x00041D41
		public unsafe UnityEvent onClose
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateMixInterface.NativeFieldInfoPtr_onClose);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateMixInterface.NativeFieldInfoPtr_onClose), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006017 RID: 24599
		private static readonly IntPtr NativeFieldInfoPtr_BEAN_REQUIREMENT;

		// Token: 0x04006018 RID: 24600
		private static readonly IntPtr NativeFieldInfoPtr__IsOpen_k__BackingField;

		// Token: 0x04006019 RID: 24601
		private static readonly IntPtr NativeFieldInfoPtr_Canvas;

		// Token: 0x0400601A RID: 24602
		private static readonly IntPtr NativeFieldInfoPtr_BeansSlot;

		// Token: 0x0400601B RID: 24603
		private static readonly IntPtr NativeFieldInfoPtr_ProductSlot;

		// Token: 0x0400601C RID: 24604
		private static readonly IntPtr NativeFieldInfoPtr_MixerSlot;

		// Token: 0x0400601D RID: 24605
		private static readonly IntPtr NativeFieldInfoPtr_OutputSlot;

		// Token: 0x0400601E RID: 24606
		private static readonly IntPtr NativeFieldInfoPtr_OutputIcon;

		// Token: 0x0400601F RID: 24607
		private static readonly IntPtr NativeFieldInfoPtr_BeginButton;

		// Token: 0x04006020 RID: 24608
		private static readonly IntPtr NativeFieldInfoPtr_Storage;

		// Token: 0x04006021 RID: 24609
		private static readonly IntPtr NativeFieldInfoPtr_ProductPropertiesLabel;

		// Token: 0x04006022 RID: 24610
		private static readonly IntPtr NativeFieldInfoPtr_OutputPropertiesLabel;

		// Token: 0x04006023 RID: 24611
		private static readonly IntPtr NativeFieldInfoPtr_BeanProblemLabel;

		// Token: 0x04006024 RID: 24612
		private static readonly IntPtr NativeFieldInfoPtr_ProductProblemLabel;

		// Token: 0x04006025 RID: 24613
		private static readonly IntPtr NativeFieldInfoPtr_MixerProblemLabel;

		// Token: 0x04006026 RID: 24614
		private static readonly IntPtr NativeFieldInfoPtr_OutputProblemLabel;

		// Token: 0x04006027 RID: 24615
		private static readonly IntPtr NativeFieldInfoPtr_CameraPosition;

		// Token: 0x04006028 RID: 24616
		private static readonly IntPtr NativeFieldInfoPtr_UnknownOutputIcon;

		// Token: 0x04006029 RID: 24617
		private static readonly IntPtr NativeFieldInfoPtr_onOpen;

		// Token: 0x0400602A RID: 24618
		private static readonly IntPtr NativeFieldInfoPtr_onClose;

		// Token: 0x0400602B RID: 24619
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;

		// Token: 0x0400602C RID: 24620
		private static readonly IntPtr NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0;

		// Token: 0x0400602D RID: 24621
		private static readonly IntPtr NativeMethodInfoPtr_get_beanSlot_Private_get_ItemSlot_0;

		// Token: 0x0400602E RID: 24622
		private static readonly IntPtr NativeMethodInfoPtr_get_mixerSlot_Private_get_ItemSlot_0;

		// Token: 0x0400602F RID: 24623
		private static readonly IntPtr NativeMethodInfoPtr_get_outputSlot_Private_get_ItemSlot_0;

		// Token: 0x04006030 RID: 24624
		private static readonly IntPtr NativeMethodInfoPtr_get_productSlot_Private_get_ItemSlot_0;

		// Token: 0x04006031 RID: 24625
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04006032 RID: 24626
		private static readonly IntPtr NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0;

		// Token: 0x04006033 RID: 24627
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Void_0;

		// Token: 0x04006034 RID: 24628
		private static readonly IntPtr NativeMethodInfoPtr_ContentsChanged_Private_Void_0;

		// Token: 0x04006035 RID: 24629
		private static readonly IntPtr NativeMethodInfoPtr_UpdateCanBegin_Private_Void_0;

		// Token: 0x04006036 RID: 24630
		private static readonly IntPtr NativeMethodInfoPtr_UpdateOutput_Private_Void_0;

		// Token: 0x04006037 RID: 24631
		private static readonly IntPtr NativeMethodInfoPtr_BeginPressed_Private_Void_0;

		// Token: 0x04006038 RID: 24632
		private static readonly IntPtr NativeMethodInfoPtr_GetOutputProperties_Private_List_1_Property_ProductDefinition_PropertyItemDefinition_0;

		// Token: 0x04006039 RID: 24633
		private static readonly IntPtr NativeMethodInfoPtr_IsOutputKnown_Private_Boolean_byref_ProductDefinition_0;

		// Token: 0x0400603A RID: 24634
		private static readonly IntPtr NativeMethodInfoPtr_GetPropertyListString_Private_String_List_1_Property_0;

		// Token: 0x0400603B RID: 24635
		private static readonly IntPtr NativeMethodInfoPtr_GetPropertyString_Private_String_Property_0;

		// Token: 0x0400603C RID: 24636
		private static readonly IntPtr NativeMethodInfoPtr_CanBegin_Private_Boolean_0;

		// Token: 0x0400603D RID: 24637
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_0;

		// Token: 0x0400603E RID: 24638
		private static readonly IntPtr NativeMethodInfoPtr_HasProduct_Private_Boolean_0;

		// Token: 0x0400603F RID: 24639
		private static readonly IntPtr NativeMethodInfoPtr_HasBeans_Private_Boolean_0;

		// Token: 0x04006040 RID: 24640
		private static readonly IntPtr NativeMethodInfoPtr_HasMixer_Private_Boolean_0;

		// Token: 0x04006041 RID: 24641
		private static readonly IntPtr NativeMethodInfoPtr_GetProduct_Private_ProductDefinition_0;

		// Token: 0x04006042 RID: 24642
		private static readonly IntPtr NativeMethodInfoPtr_GetMixer_Private_PropertyItemDefinition_0;

		// Token: 0x04006043 RID: 24643
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
