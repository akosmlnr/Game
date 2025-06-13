using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Object.Synchronizing;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.UI.Construction.Features;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Construction.Features
{
	// Token: 0x020004A4 RID: 1188
	public class ColorFeature : Feature
	{
		// Token: 0x06006600 RID: 26112 RVA: 0x001CF8E8 File Offset: 0x001CDAE8
		// Note: this type is marked as 'beforefieldinit'.
		static ColorFeature()
		{
			Il2CppClassPointerStore<ColorFeature>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Construction.Features", "ColorFeature");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ColorFeature>.NativeClassPtr);
			ColorFeature.NativeFieldInfoPtr_colorTargets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorFeature>.NativeClassPtr, "colorTargets");
			ColorFeature.NativeFieldInfoPtr_secondaryTargets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorFeature>.NativeClassPtr, "secondaryTargets");
			ColorFeature.NativeFieldInfoPtr_colors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorFeature>.NativeClassPtr, "colors");
			ColorFeature.NativeFieldInfoPtr_defaultColorIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorFeature>.NativeClassPtr, "defaultColorIndex");
			ColorFeature.NativeFieldInfoPtr_ownedColorIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorFeature>.NativeClassPtr, "ownedColorIndex");
			ColorFeature.NativeFieldInfoPtr_syncVar___ownedColorIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorFeature>.NativeClassPtr, "syncVar___ownedColorIndex");
			ColorFeature.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorFeature>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Construction.Features.ColorFeatureAssembly-CSharp.dll_Excuted");
			ColorFeature.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorFeature>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Construction.Features.ColorFeatureAssembly-CSharp.dll_Excuted");
			ColorFeature.NativeMethodInfoPtr_CreateInterface_Public_Virtual_FI_Base_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorFeature>.NativeClassPtr, 100676318);
			ColorFeature.NativeMethodInfoPtr_Default_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorFeature>.NativeClassPtr, 100676319);
			ColorFeature.NativeMethodInfoPtr_ApplyColor_Private_Void_NamedColor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorFeature>.NativeClassPtr, 100676320);
			ColorFeature.NativeMethodInfoPtr_ModifyColor_Public_Static_Color_Color_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorFeature>.NativeClassPtr, 100676321);
			ColorFeature.NativeMethodInfoPtr_SetData_Protected_Virtual_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorFeature>.NativeClassPtr, 100676322);
			ColorFeature.NativeMethodInfoPtr_ReceiveData_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorFeature>.NativeClassPtr, 100676323);
			ColorFeature.NativeMethodInfoPtr_BuyColor_Private_Void_NamedColor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorFeature>.NativeClassPtr, 100676324);
			ColorFeature.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorFeature>.NativeClassPtr, 100676325);
			ColorFeature.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorFeature>.NativeClassPtr, 100676326);
			ColorFeature.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorFeature>.NativeClassPtr, 100676327);
			ColorFeature.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorFeature>.NativeClassPtr, 100676328);
			ColorFeature.NativeMethodInfoPtr_RpcWriter___Server_SetData_3316948804_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorFeature>.NativeClassPtr, 100676329);
			ColorFeature.NativeMethodInfoPtr_RpcLogic___SetData_3316948804_Protected_Virtual_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorFeature>.NativeClassPtr, 100676330);
			ColorFeature.NativeMethodInfoPtr_RpcReader___Server_SetData_3316948804_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorFeature>.NativeClassPtr, 100676331);
			ColorFeature.NativeMethodInfoPtr_sync___get_value_ownedColorIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorFeature>.NativeClassPtr, 100676332);
			ColorFeature.NativeMethodInfoPtr_sync___set_value_ownedColorIndex_Public_set_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorFeature>.NativeClassPtr, 100676333);
			ColorFeature.NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_Construction_Features_ColorFeature_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorFeature>.NativeClassPtr, 100676334);
			ColorFeature.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorFeature>.NativeClassPtr, 100676335);
		}

		// Token: 0x06006601 RID: 26113 RVA: 0x001CFB20 File Offset: 0x001CDD20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208538, XrefRangeEnd = 208565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override FI_Base CreateInterface(Transform parent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ColorFeature.NativeMethodInfoPtr_CreateInterface_Public_Virtual_FI_Base_Transform_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<FI_Base>(intPtr2) : null;
		}

		// Token: 0x06006602 RID: 26114 RVA: 0x001CFB7C File Offset: 0x001CDD7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208565, XrefRangeEnd = 208572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Default()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ColorFeature.NativeMethodInfoPtr_Default_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006603 RID: 26115 RVA: 0x001CFBB8 File Offset: 0x001CDDB8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 208598, RefRangeEnd = 208599, XrefRangeStart = 208572, XrefRangeEnd = 208598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyColor(ColorFeature.NamedColor color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(color);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorFeature.NativeMethodInfoPtr_ApplyColor_Private_Void_NamedColor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006604 RID: 26116 RVA: 0x001CFBFC File Offset: 0x001CDDFC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 208603, RefRangeEnd = 208604, XrefRangeStart = 208599, XrefRangeEnd = 208603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Color ModifyColor(Color original, float sChange, float vChange)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref original;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref sChange;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref vChange;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(ColorFeature.NativeMethodInfoPtr_ModifyColor_Public_Static_Color_Color_Single_Single_0, 0, (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06006605 RID: 26117 RVA: 0x001CFC58 File Offset: 0x001CDE58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208604, XrefRangeEnd = 208627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetData(int colorIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref colorIndex;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ColorFeature.NativeMethodInfoPtr_SetData_Protected_Virtual_New_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006606 RID: 26118 RVA: 0x001CFCA4 File Offset: 0x001CDEA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208627, XrefRangeEnd = 208632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReceiveData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorFeature.NativeMethodInfoPtr_ReceiveData_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006607 RID: 26119 RVA: 0x001CFCD8 File Offset: 0x001CDED8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208632, XrefRangeEnd = 208636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BuyColor(ColorFeature.NamedColor color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(color);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorFeature.NativeMethodInfoPtr_BuyColor_Private_Void_NamedColor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006608 RID: 26120 RVA: 0x001CFD1C File Offset: 0x001CDF1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208636, XrefRangeEnd = 208662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ColorFeature() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ColorFeature>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorFeature.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006609 RID: 26121 RVA: 0x001CFD58 File Offset: 0x001CDF58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208662, XrefRangeEnd = 208685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ColorFeature.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600660A RID: 26122 RVA: 0x001CFD94 File Offset: 0x001CDF94
		[CallerCount(0)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ColorFeature.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600660B RID: 26123 RVA: 0x001CFDD0 File Offset: 0x001CDFD0
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ColorFeature.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600660C RID: 26124 RVA: 0x001CFE0C File Offset: 0x001CE00C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208685, XrefRangeEnd = 208696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SetData_3316948804(int colorIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref colorIndex;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorFeature.NativeMethodInfoPtr_RpcWriter___Server_SetData_3316948804_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600660D RID: 26125 RVA: 0x001CFE4C File Offset: 0x001CE04C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 208705, RefRangeEnd = 208707, XrefRangeStart = 208696, XrefRangeEnd = 208705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RpcLogic___SetData_3316948804(int colorIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref colorIndex;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ColorFeature.NativeMethodInfoPtr_RpcLogic___SetData_3316948804_Protected_Virtual_New_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600660E RID: 26126 RVA: 0x001CFE98 File Offset: 0x001CE098
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208707, XrefRangeEnd = 208712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SetData_3316948804(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorFeature.NativeMethodInfoPtr_RpcReader___Server_SetData_3316948804_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x17001E99 RID: 7833
		// (get) Token: 0x0600660F RID: 26127 RVA: 0x001CFEFC File Offset: 0x001CE0FC
		// (set) Token: 0x06006610 RID: 26128 RVA: 0x001CFF38 File Offset: 0x001CE138
		public unsafe int SyncAccessor_ownedColorIndex
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(ColorFeature.NativeMethodInfoPtr_sync___get_value_ownedColorIndex_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 208720, RefRangeEnd = 208721, XrefRangeStart = 208712, XrefRangeEnd = 208720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref value;
				ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref value;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorFeature.NativeMethodInfoPtr_sync___set_value_ownedColorIndex_Public_set_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06006611 RID: 26129 RVA: 0x001CFF84 File Offset: 0x001CE184
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208721, XrefRangeEnd = 208726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool ReadSyncVar___ScheduleOne_Construction_Features_ColorFeature(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref UInt321;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref Boolean2;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ColorFeature.NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_Construction_Features_ColorFeature_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06006612 RID: 26130 RVA: 0x001CFFF8 File Offset: 0x001CE1F8
		[CallerCount(0)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ColorFeature.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006613 RID: 26131 RVA: 0x0003001B File Offset: 0x0002E21B
		public ColorFeature(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001E91 RID: 7825
		// (get) Token: 0x06006614 RID: 26132 RVA: 0x001D0034 File Offset: 0x001CE234
		// (set) Token: 0x06006615 RID: 26133 RVA: 0x00030024 File Offset: 0x0002E224
		public unsafe List<MeshRenderer> colorTargets
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ColorFeature.NativeFieldInfoPtr_colorTargets);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<MeshRenderer>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ColorFeature.NativeFieldInfoPtr_colorTargets), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E92 RID: 7826
		// (get) Token: 0x06006616 RID: 26134 RVA: 0x001D0064 File Offset: 0x001CE264
		// (set) Token: 0x06006617 RID: 26135 RVA: 0x00030043 File Offset: 0x0002E243
		public unsafe List<ColorFeature.SecondaryPaintTarget> secondaryTargets
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ColorFeature.NativeFieldInfoPtr_secondaryTargets);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ColorFeature.SecondaryPaintTarget>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ColorFeature.NativeFieldInfoPtr_secondaryTargets), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E93 RID: 7827
		// (get) Token: 0x06006618 RID: 26136 RVA: 0x001D0094 File Offset: 0x001CE294
		// (set) Token: 0x06006619 RID: 26137 RVA: 0x00030062 File Offset: 0x0002E262
		public unsafe List<ColorFeature.NamedColor> colors
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ColorFeature.NativeFieldInfoPtr_colors);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ColorFeature.NamedColor>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ColorFeature.NativeFieldInfoPtr_colors), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E94 RID: 7828
		// (get) Token: 0x0600661A RID: 26138 RVA: 0x001D00C4 File Offset: 0x001CE2C4
		// (set) Token: 0x0600661B RID: 26139 RVA: 0x00030081 File Offset: 0x0002E281
		public unsafe int defaultColorIndex
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ColorFeature.NativeFieldInfoPtr_defaultColorIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ColorFeature.NativeFieldInfoPtr_defaultColorIndex)) = value;
			}
		}

		// Token: 0x17001E95 RID: 7829
		// (get) Token: 0x0600661C RID: 26140 RVA: 0x001D00EC File Offset: 0x001CE2EC
		// (set) Token: 0x0600661D RID: 26141 RVA: 0x0003009C File Offset: 0x0002E29C
		public unsafe int ownedColorIndex
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ColorFeature.NativeFieldInfoPtr_ownedColorIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ColorFeature.NativeFieldInfoPtr_ownedColorIndex)) = value;
			}
		}

		// Token: 0x17001E96 RID: 7830
		// (get) Token: 0x0600661E RID: 26142 RVA: 0x001D0114 File Offset: 0x001CE314
		// (set) Token: 0x0600661F RID: 26143 RVA: 0x000300B7 File Offset: 0x0002E2B7
		public unsafe SyncVar<int> syncVar___ownedColorIndex
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ColorFeature.NativeFieldInfoPtr_syncVar___ownedColorIndex);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyncVar<int>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ColorFeature.NativeFieldInfoPtr_syncVar___ownedColorIndex), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E97 RID: 7831
		// (get) Token: 0x06006620 RID: 26144 RVA: 0x001D0144 File Offset: 0x001CE344
		// (set) Token: 0x06006621 RID: 26145 RVA: 0x000300D6 File Offset: 0x0002E2D6
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ColorFeature.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ColorFeature.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17001E98 RID: 7832
		// (get) Token: 0x06006622 RID: 26146 RVA: 0x001D016C File Offset: 0x001CE36C
		// (set) Token: 0x06006623 RID: 26147 RVA: 0x000300F1 File Offset: 0x0002E2F1
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ColorFeature.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ColorFeature.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x0400459D RID: 17821
		private static readonly System.IntPtr NativeFieldInfoPtr_colorTargets;

		// Token: 0x0400459E RID: 17822
		private static readonly System.IntPtr NativeFieldInfoPtr_secondaryTargets;

		// Token: 0x0400459F RID: 17823
		private static readonly System.IntPtr NativeFieldInfoPtr_colors;

		// Token: 0x040045A0 RID: 17824
		private static readonly System.IntPtr NativeFieldInfoPtr_defaultColorIndex;

		// Token: 0x040045A1 RID: 17825
		private static readonly System.IntPtr NativeFieldInfoPtr_ownedColorIndex;

		// Token: 0x040045A2 RID: 17826
		private static readonly System.IntPtr NativeFieldInfoPtr_syncVar___ownedColorIndex;

		// Token: 0x040045A3 RID: 17827
		private static readonly System.IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x040045A4 RID: 17828
		private static readonly System.IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x040045A5 RID: 17829
		private static readonly System.IntPtr NativeMethodInfoPtr_CreateInterface_Public_Virtual_FI_Base_Transform_0;

		// Token: 0x040045A6 RID: 17830
		private static readonly System.IntPtr NativeMethodInfoPtr_Default_Public_Virtual_Void_0;

		// Token: 0x040045A7 RID: 17831
		private static readonly System.IntPtr NativeMethodInfoPtr_ApplyColor_Private_Void_NamedColor_0;

		// Token: 0x040045A8 RID: 17832
		private static readonly System.IntPtr NativeMethodInfoPtr_ModifyColor_Public_Static_Color_Color_Single_Single_0;

		// Token: 0x040045A9 RID: 17833
		private static readonly System.IntPtr NativeMethodInfoPtr_SetData_Protected_Virtual_New_Void_Int32_0;

		// Token: 0x040045AA RID: 17834
		private static readonly System.IntPtr NativeMethodInfoPtr_ReceiveData_Private_Void_0;

		// Token: 0x040045AB RID: 17835
		private static readonly System.IntPtr NativeMethodInfoPtr_BuyColor_Private_Void_NamedColor_0;

		// Token: 0x040045AC RID: 17836
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040045AD RID: 17837
		private static readonly System.IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x040045AE RID: 17838
		private static readonly System.IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x040045AF RID: 17839
		private static readonly System.IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x040045B0 RID: 17840
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Server_SetData_3316948804_Private_Void_Int32_0;

		// Token: 0x040045B1 RID: 17841
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___SetData_3316948804_Protected_Virtual_New_Void_Int32_0;

		// Token: 0x040045B2 RID: 17842
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Server_SetData_3316948804_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x040045B3 RID: 17843
		private static readonly System.IntPtr NativeMethodInfoPtr_sync___get_value_ownedColorIndex_Public_get_Int32_0;

		// Token: 0x040045B4 RID: 17844
		private static readonly System.IntPtr NativeMethodInfoPtr_sync___set_value_ownedColorIndex_Public_set_Void_Int32_Boolean_0;

		// Token: 0x040045B5 RID: 17845
		private static readonly System.IntPtr NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_Construction_Features_ColorFeature_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0;

		// Token: 0x040045B6 RID: 17846
		private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x02000A79 RID: 2681
		[System.Serializable]
		public class NamedColor : Il2CppSystem.Object
		{
			// Token: 0x0600D47B RID: 54395 RVA: 0x00332C58 File Offset: 0x00330E58
			// Note: this type is marked as 'beforefieldinit'.
			static NamedColor()
			{
				Il2CppClassPointerStore<ColorFeature.NamedColor>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ColorFeature>.NativeClassPtr, "NamedColor");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ColorFeature.NamedColor>.NativeClassPtr);
				ColorFeature.NamedColor.NativeFieldInfoPtr_colorName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorFeature.NamedColor>.NativeClassPtr, "colorName");
				ColorFeature.NamedColor.NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorFeature.NamedColor>.NativeClassPtr, "color");
				ColorFeature.NamedColor.NativeFieldInfoPtr_price = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorFeature.NamedColor>.NativeClassPtr, "price");
				ColorFeature.NamedColor.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorFeature.NamedColor>.NativeClassPtr, 100676336);
			}

			// Token: 0x0600D47C RID: 54396 RVA: 0x00332CD4 File Offset: 0x00330ED4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208529, XrefRangeEnd = 208530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe NamedColor() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ColorFeature.NamedColor>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorFeature.NamedColor.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D47D RID: 54397 RVA: 0x000670AC File Offset: 0x000652AC
			public NamedColor(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170041B8 RID: 16824
			// (get) Token: 0x0600D47E RID: 54398 RVA: 0x00332D10 File Offset: 0x00330F10
			// (set) Token: 0x0600D47F RID: 54399 RVA: 0x000670B5 File Offset: 0x000652B5
			public unsafe string colorName
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ColorFeature.NamedColor.NativeFieldInfoPtr_colorName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ColorFeature.NamedColor.NativeFieldInfoPtr_colorName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170041B9 RID: 16825
			// (get) Token: 0x0600D480 RID: 54400 RVA: 0x00332D38 File Offset: 0x00330F38
			// (set) Token: 0x0600D481 RID: 54401 RVA: 0x000670D4 File Offset: 0x000652D4
			public unsafe Color color
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ColorFeature.NamedColor.NativeFieldInfoPtr_color);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ColorFeature.NamedColor.NativeFieldInfoPtr_color)) = value;
				}
			}

			// Token: 0x170041BA RID: 16826
			// (get) Token: 0x0600D482 RID: 54402 RVA: 0x00332D60 File Offset: 0x00330F60
			// (set) Token: 0x0600D483 RID: 54403 RVA: 0x000670EF File Offset: 0x000652EF
			public unsafe float price
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ColorFeature.NamedColor.NativeFieldInfoPtr_price);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ColorFeature.NamedColor.NativeFieldInfoPtr_price)) = value;
				}
			}

			// Token: 0x04008F64 RID: 36708
			private static readonly System.IntPtr NativeFieldInfoPtr_colorName;

			// Token: 0x04008F65 RID: 36709
			private static readonly System.IntPtr NativeFieldInfoPtr_color;

			// Token: 0x04008F66 RID: 36710
			private static readonly System.IntPtr NativeFieldInfoPtr_price;

			// Token: 0x04008F67 RID: 36711
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000A7A RID: 2682
		[System.Serializable]
		public class SecondaryPaintTarget : Il2CppSystem.Object
		{
			// Token: 0x0600D484 RID: 54404 RVA: 0x00332D88 File Offset: 0x00330F88
			// Note: this type is marked as 'beforefieldinit'.
			static SecondaryPaintTarget()
			{
				Il2CppClassPointerStore<ColorFeature.SecondaryPaintTarget>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ColorFeature>.NativeClassPtr, "SecondaryPaintTarget");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ColorFeature.SecondaryPaintTarget>.NativeClassPtr);
				ColorFeature.SecondaryPaintTarget.NativeFieldInfoPtr_colorTargets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorFeature.SecondaryPaintTarget>.NativeClassPtr, "colorTargets");
				ColorFeature.SecondaryPaintTarget.NativeFieldInfoPtr_sChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorFeature.SecondaryPaintTarget>.NativeClassPtr, "sChange");
				ColorFeature.SecondaryPaintTarget.NativeFieldInfoPtr_vChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorFeature.SecondaryPaintTarget>.NativeClassPtr, "vChange");
				ColorFeature.SecondaryPaintTarget.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorFeature.SecondaryPaintTarget>.NativeClassPtr, 100676337);
			}

			// Token: 0x0600D485 RID: 54405 RVA: 0x00332E04 File Offset: 0x00331004
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208530, XrefRangeEnd = 208538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SecondaryPaintTarget() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ColorFeature.SecondaryPaintTarget>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorFeature.SecondaryPaintTarget.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D486 RID: 54406 RVA: 0x0006710A File Offset: 0x0006530A
			public SecondaryPaintTarget(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170041BB RID: 16827
			// (get) Token: 0x0600D487 RID: 54407 RVA: 0x00332E40 File Offset: 0x00331040
			// (set) Token: 0x0600D488 RID: 54408 RVA: 0x00067113 File Offset: 0x00065313
			public unsafe List<MeshRenderer> colorTargets
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ColorFeature.SecondaryPaintTarget.NativeFieldInfoPtr_colorTargets);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<MeshRenderer>>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ColorFeature.SecondaryPaintTarget.NativeFieldInfoPtr_colorTargets), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170041BC RID: 16828
			// (get) Token: 0x0600D489 RID: 54409 RVA: 0x00332E70 File Offset: 0x00331070
			// (set) Token: 0x0600D48A RID: 54410 RVA: 0x00067132 File Offset: 0x00065332
			public unsafe float sChange
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ColorFeature.SecondaryPaintTarget.NativeFieldInfoPtr_sChange);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ColorFeature.SecondaryPaintTarget.NativeFieldInfoPtr_sChange)) = value;
				}
			}

			// Token: 0x170041BD RID: 16829
			// (get) Token: 0x0600D48B RID: 54411 RVA: 0x00332E98 File Offset: 0x00331098
			// (set) Token: 0x0600D48C RID: 54412 RVA: 0x0006714D File Offset: 0x0006534D
			public unsafe float vChange
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ColorFeature.SecondaryPaintTarget.NativeFieldInfoPtr_vChange);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ColorFeature.SecondaryPaintTarget.NativeFieldInfoPtr_vChange)) = value;
				}
			}

			// Token: 0x04008F68 RID: 36712
			private static readonly System.IntPtr NativeFieldInfoPtr_colorTargets;

			// Token: 0x04008F69 RID: 36713
			private static readonly System.IntPtr NativeFieldInfoPtr_sChange;

			// Token: 0x04008F6A RID: 36714
			private static readonly System.IntPtr NativeFieldInfoPtr_vChange;

			// Token: 0x04008F6B RID: 36715
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
