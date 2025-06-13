using System;
using Il2CppEPOOutline;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Object;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Construction.Features;
using Il2CppScheduleOne.EntityFramework;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.ConstructableScripts
{
	// Token: 0x020005ED RID: 1517
	public class Constructable : NetworkBehaviour
	{
		// Token: 0x06008469 RID: 33897 RVA: 0x00235F00 File Offset: 0x00234100
		// Note: this type is marked as 'beforefieldinit'.
		static Constructable()
		{
			Il2CppClassPointerStore<Constructable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ConstructableScripts", "Constructable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Constructable>.NativeClassPtr);
			Constructable.NativeFieldInfoPtr_isStatic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Constructable>.NativeClassPtr, "isStatic");
			Constructable.NativeFieldInfoPtr_constructableName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Constructable>.NativeClassPtr, "constructableName");
			Constructable.NativeFieldInfoPtr_constructableDescription = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Constructable>.NativeClassPtr, "constructableDescription");
			Constructable.NativeFieldInfoPtr_constructableAssetPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Constructable>.NativeClassPtr, "constructableAssetPath");
			Constructable.NativeFieldInfoPtr_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Constructable>.NativeClassPtr, "ID");
			Constructable.NativeFieldInfoPtr_constructableIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Constructable>.NativeClassPtr, "constructableIcon");
			Constructable.NativeFieldInfoPtr_boundingBox = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Constructable>.NativeClassPtr, "boundingBox");
			Constructable.NativeFieldInfoPtr_constructionHandler_Asset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Constructable>.NativeClassPtr, "constructionHandler_Asset");
			Constructable.NativeFieldInfoPtr_outlineRenderers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Constructable>.NativeClassPtr, "outlineRenderers");
			Constructable.NativeFieldInfoPtr_outlineEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Constructable>.NativeClassPtr, "outlineEffect");
			Constructable.NativeFieldInfoPtr_features = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Constructable>.NativeClassPtr, "features");
			Constructable.NativeFieldInfoPtr__isVisible_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Constructable>.NativeClassPtr, "<isVisible>k__BackingField");
			Constructable.NativeFieldInfoPtr_isDestroyed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Constructable>.NativeClassPtr, "isDestroyed");
			Constructable.NativeFieldInfoPtr_originalLayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Constructable>.NativeClassPtr, "originalLayers");
			Constructable.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Constructable>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.ConstructableScripts.ConstructableAssembly-CSharp.dll_Excuted");
			Constructable.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Constructable>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.ConstructableScripts.ConstructableAssembly-CSharp.dll_Excuted");
			Constructable.NativeMethodInfoPtr_get_IsStatic_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable>.NativeClassPtr, 100679952);
			Constructable.NativeMethodInfoPtr_get_ConstructableName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable>.NativeClassPtr, 100679953);
			Constructable.NativeMethodInfoPtr_get_ConstructableDescription_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable>.NativeClassPtr, 100679954);
			Constructable.NativeMethodInfoPtr_get_ConstructableAssetPath_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable>.NativeClassPtr, 100679955);
			Constructable.NativeMethodInfoPtr_get_PrefabID_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable>.NativeClassPtr, 100679956);
			Constructable.NativeMethodInfoPtr_get_ConstructableIcon_Public_get_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable>.NativeClassPtr, 100679957);
			Constructable.NativeMethodInfoPtr_get__constructionHandler_Asset_Public_get_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable>.NativeClassPtr, 100679958);
			Constructable.NativeMethodInfoPtr_get_isVisible_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable>.NativeClassPtr, 100679959);
			Constructable.NativeMethodInfoPtr_set_isVisible_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable>.NativeClassPtr, 100679960);
			Constructable.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable>.NativeClassPtr, 100679961);
			Constructable.NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable>.NativeClassPtr, 100679962);
			Constructable.NativeMethodInfoPtr_CanBeDestroyed_Public_Virtual_New_Boolean_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable>.NativeClassPtr, 100679963);
			Constructable.NativeMethodInfoPtr_CanBeDestroyed_Public_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable>.NativeClassPtr, 100679964);
			Constructable.NativeMethodInfoPtr_DestroyConstructable_Public_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable>.NativeClassPtr, 100679965);
			Constructable.NativeMethodInfoPtr_Destroy_Networked_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable>.NativeClassPtr, 100679966);
			Constructable.NativeMethodInfoPtr_DestroyConstructableWrapper_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable>.NativeClassPtr, 100679967);
			Constructable.NativeMethodInfoPtr_CanBeModified_Public_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable>.NativeClassPtr, 100679968);
			Constructable.NativeMethodInfoPtr_CanBePickedUpByHand_Public_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable>.NativeClassPtr, 100679969);
			Constructable.NativeMethodInfoPtr_CanBeSelected_Public_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable>.NativeClassPtr, 100679970);
			Constructable.NativeMethodInfoPtr_GetBuildableVersionAssetPath_Public_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable>.NativeClassPtr, 100679971);
			Constructable.NativeMethodInfoPtr_ShowOutline_Public_Void_EOutlineColor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable>.NativeClassPtr, 100679972);
			Constructable.NativeMethodInfoPtr_HideOutline_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable>.NativeClassPtr, 100679973);
			Constructable.NativeMethodInfoPtr_GetCosmeticCenter_Public_Virtual_New_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable>.NativeClassPtr, 100679974);
			Constructable.NativeMethodInfoPtr_GetBoundingBoxLongestSide_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable>.NativeClassPtr, 100679975);
			Constructable.NativeMethodInfoPtr_SetInvisible_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable>.NativeClassPtr, 100679976);
			Constructable.NativeMethodInfoPtr_RestoreVisibility_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable>.NativeClassPtr, 100679977);
			Constructable.NativeMethodInfoPtr_SetLayerRecursively_Public_Void_GameObject_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable>.NativeClassPtr, 100679978);
			Constructable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable>.NativeClassPtr, 100679979);
			Constructable.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable>.NativeClassPtr, 100679980);
			Constructable.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable>.NativeClassPtr, 100679981);
			Constructable.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable>.NativeClassPtr, 100679982);
			Constructable.NativeMethodInfoPtr_RpcWriter___Server_Destroy_Networked_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable>.NativeClassPtr, 100679983);
			Constructable.NativeMethodInfoPtr_RpcLogic___Destroy_Networked_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable>.NativeClassPtr, 100679984);
			Constructable.NativeMethodInfoPtr_RpcReader___Server_Destroy_Networked_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable>.NativeClassPtr, 100679985);
			Constructable.NativeMethodInfoPtr_RpcWriter___Observers_DestroyConstructableWrapper_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable>.NativeClassPtr, 100679986);
			Constructable.NativeMethodInfoPtr_RpcLogic___DestroyConstructableWrapper_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable>.NativeClassPtr, 100679987);
			Constructable.NativeMethodInfoPtr_RpcReader___Observers_DestroyConstructableWrapper_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable>.NativeClassPtr, 100679988);
			Constructable.NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable>.NativeClassPtr, 100679989);
		}

		// Token: 0x170027F0 RID: 10224
		// (get) Token: 0x0600846A RID: 33898 RVA: 0x00236368 File Offset: 0x00234568
		public unsafe bool IsStatic
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Constructable.NativeMethodInfoPtr_get_IsStatic_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x170027F1 RID: 10225
		// (get) Token: 0x0600846B RID: 33899 RVA: 0x002363A4 File Offset: 0x002345A4
		public unsafe string ConstructableName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(Constructable.NativeMethodInfoPtr_get_ConstructableName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
		}

		// Token: 0x170027F2 RID: 10226
		// (get) Token: 0x0600846C RID: 33900 RVA: 0x002363DC File Offset: 0x002345DC
		public unsafe string ConstructableDescription
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(Constructable.NativeMethodInfoPtr_get_ConstructableDescription_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
		}

		// Token: 0x170027F3 RID: 10227
		// (get) Token: 0x0600846D RID: 33901 RVA: 0x00236414 File Offset: 0x00234614
		public unsafe string ConstructableAssetPath
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(Constructable.NativeMethodInfoPtr_get_ConstructableAssetPath_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
		}

		// Token: 0x170027F4 RID: 10228
		// (get) Token: 0x0600846E RID: 33902 RVA: 0x0023644C File Offset: 0x0023464C
		public unsafe string PrefabID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(Constructable.NativeMethodInfoPtr_get_PrefabID_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
		}

		// Token: 0x170027F5 RID: 10229
		// (get) Token: 0x0600846F RID: 33903 RVA: 0x00236484 File Offset: 0x00234684
		public unsafe Sprite ConstructableIcon
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Constructable.NativeMethodInfoPtr_get_ConstructableIcon_Public_get_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
		}

		// Token: 0x170027F6 RID: 10230
		// (get) Token: 0x06008470 RID: 33904 RVA: 0x002364C4 File Offset: 0x002346C4
		public unsafe GameObject _constructionHandler_Asset
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Constructable.NativeMethodInfoPtr_get__constructionHandler_Asset_Public_get_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
		}

		// Token: 0x170027F7 RID: 10231
		// (get) Token: 0x06008471 RID: 33905 RVA: 0x00236504 File Offset: 0x00234704
		// (set) Token: 0x06008472 RID: 33906 RVA: 0x00236540 File Offset: 0x00234740
		public unsafe bool isVisible
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Constructable.NativeMethodInfoPtr_get_isVisible_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Constructable.NativeMethodInfoPtr_set_isVisible_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06008473 RID: 33907 RVA: 0x00236580 File Offset: 0x00234780
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 249666, RefRangeEnd = 249667, XrefRangeStart = 249665, XrefRangeEnd = 249666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Constructable.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008474 RID: 33908 RVA: 0x002365BC File Offset: 0x002347BC
		[CallerCount(2576)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnStartClient()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Constructable.NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008475 RID: 33909 RVA: 0x002365F8 File Offset: 0x002347F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249667, XrefRangeEnd = 249670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool CanBeDestroyed(out string reason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr il2CppString = 0;
			ptr2 = &il2CppString;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Constructable.NativeMethodInfoPtr_CanBeDestroyed_Public_Virtual_New_Boolean_byref_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			reason = IL2CPP.Il2CppStringToManaged(il2CppString);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06008476 RID: 33910 RVA: 0x0023665C File Offset: 0x0023485C
		[CallerCount(0)]
		public unsafe virtual bool CanBeDestroyed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Constructable.NativeMethodInfoPtr_CanBeDestroyed_Public_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06008477 RID: 33911 RVA: 0x002366A4 File Offset: 0x002348A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 249697, RefRangeEnd = 249698, XrefRangeStart = 249670, XrefRangeEnd = 249697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void DestroyConstructable(bool callOnServer = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref callOnServer;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Constructable.NativeMethodInfoPtr_DestroyConstructable_Public_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008478 RID: 33912 RVA: 0x002366F0 File Offset: 0x002348F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249698, XrefRangeEnd = 249707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Destroy_Networked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Constructable.NativeMethodInfoPtr_Destroy_Networked_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008479 RID: 33913 RVA: 0x00236724 File Offset: 0x00234924
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249707, XrefRangeEnd = 249716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DestroyConstructableWrapper()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Constructable.NativeMethodInfoPtr_DestroyConstructableWrapper_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600847A RID: 33914 RVA: 0x00236758 File Offset: 0x00234958
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 31612, RefRangeEnd = 31633, XrefRangeStart = 31612, XrefRangeEnd = 31633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool CanBeModified()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Constructable.NativeMethodInfoPtr_CanBeModified_Public_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600847B RID: 33915 RVA: 0x002367A0 File Offset: 0x002349A0
		[CallerCount(176)]
		[CachedScanResults(RefRangeStart = 38110, RefRangeEnd = 38286, XrefRangeStart = 38110, XrefRangeEnd = 38286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool CanBePickedUpByHand()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Constructable.NativeMethodInfoPtr_CanBePickedUpByHand_Public_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600847C RID: 33916 RVA: 0x002367E8 File Offset: 0x002349E8
		[CallerCount(0)]
		public unsafe virtual bool CanBeSelected()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Constructable.NativeMethodInfoPtr_CanBeSelected_Public_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600847D RID: 33917 RVA: 0x00236830 File Offset: 0x00234A30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249716, XrefRangeEnd = 249718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetBuildableVersionAssetPath()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Constructable.NativeMethodInfoPtr_GetBuildableVersionAssetPath_Public_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}

		// Token: 0x0600847E RID: 33918 RVA: 0x00236874 File Offset: 0x00234A74
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 249761, RefRangeEnd = 249764, XrefRangeStart = 249718, XrefRangeEnd = 249761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShowOutline(BuildableItem.EOutlineColor color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref color;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Constructable.NativeMethodInfoPtr_ShowOutline_Public_Void_EOutlineColor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600847F RID: 33919 RVA: 0x002368B4 File Offset: 0x00234AB4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 249769, RefRangeEnd = 249771, XrefRangeStart = 249764, XrefRangeEnd = 249769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HideOutline()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Constructable.NativeMethodInfoPtr_HideOutline_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008480 RID: 33920 RVA: 0x002368E8 File Offset: 0x00234AE8
		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 142440, RefRangeEnd = 142457, XrefRangeStart = 142440, XrefRangeEnd = 142457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Vector3 GetCosmeticCenter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Constructable.NativeMethodInfoPtr_GetCosmeticCenter_Public_Virtual_New_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06008481 RID: 33921 RVA: 0x00236930 File Offset: 0x00234B30
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 249774, RefRangeEnd = 249775, XrefRangeStart = 249771, XrefRangeEnd = 249774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetBoundingBoxLongestSide()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Constructable.NativeMethodInfoPtr_GetBoundingBoxLongestSide_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06008482 RID: 33922 RVA: 0x0023696C File Offset: 0x00234B6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249775, XrefRangeEnd = 249780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetInvisible()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Constructable.NativeMethodInfoPtr_SetInvisible_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008483 RID: 33923 RVA: 0x002369A8 File Offset: 0x00234BA8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 249803, RefRangeEnd = 249804, XrefRangeStart = 249780, XrefRangeEnd = 249803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RestoreVisibility()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Constructable.NativeMethodInfoPtr_RestoreVisibility_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008484 RID: 33924 RVA: 0x002369E4 File Offset: 0x00234BE4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 249836, RefRangeEnd = 249838, XrefRangeStart = 249804, XrefRangeEnd = 249836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetLayerRecursively(GameObject go, int layerNumber)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(go);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layerNumber;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Constructable.NativeMethodInfoPtr_SetLayerRecursively_Public_Void_GameObject_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008485 RID: 33925 RVA: 0x00236A34 File Offset: 0x00234C34
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 249873, RefRangeEnd = 249874, XrefRangeStart = 249838, XrefRangeEnd = 249873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Constructable() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Constructable>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Constructable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008486 RID: 33926 RVA: 0x00236A70 File Offset: 0x00234C70
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 249888, RefRangeEnd = 249889, XrefRangeStart = 249874, XrefRangeEnd = 249888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Constructable.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008487 RID: 33927 RVA: 0x00236AAC File Offset: 0x00234CAC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 237987, RefRangeEnd = 237988, XrefRangeStart = 237987, XrefRangeEnd = 237988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Constructable.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008488 RID: 33928 RVA: 0x00236AE8 File Offset: 0x00234CE8
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Constructable.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008489 RID: 33929 RVA: 0x00236B24 File Offset: 0x00234D24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_Destroy_Networked_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Constructable.NativeMethodInfoPtr_RpcWriter___Server_Destroy_Networked_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600848A RID: 33930 RVA: 0x00236B58 File Offset: 0x00234D58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249889, XrefRangeEnd = 249918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___Destroy_Networked_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Constructable.NativeMethodInfoPtr_RpcLogic___Destroy_Networked_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600848B RID: 33931 RVA: 0x00236B8C File Offset: 0x00234D8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249918, XrefRangeEnd = 249948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_Destroy_Networked_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Constructable.NativeMethodInfoPtr_RpcReader___Server_Destroy_Networked_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600848C RID: 33932 RVA: 0x00236BF0 File Offset: 0x00234DF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_DestroyConstructableWrapper_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Constructable.NativeMethodInfoPtr_RpcWriter___Observers_DestroyConstructableWrapper_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600848D RID: 33933 RVA: 0x00236C24 File Offset: 0x00234E24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249948, XrefRangeEnd = 249954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___DestroyConstructableWrapper_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Constructable.NativeMethodInfoPtr_RpcLogic___DestroyConstructableWrapper_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600848E RID: 33934 RVA: 0x00236C58 File Offset: 0x00234E58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249954, XrefRangeEnd = 249961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_DestroyConstructableWrapper_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Constructable.NativeMethodInfoPtr_RpcReader___Observers_DestroyConstructableWrapper_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600848F RID: 33935 RVA: 0x00236CA8 File Offset: 0x00234EA8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 249980, RefRangeEnd = 249982, XrefRangeStart = 249961, XrefRangeEnd = 249980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Method_Protected_Virtual_New_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Constructable.NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008490 RID: 33936 RVA: 0x0003EB9F File Offset: 0x0003CD9F
		public Constructable(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170027E0 RID: 10208
		// (get) Token: 0x06008491 RID: 33937 RVA: 0x00236CE4 File Offset: 0x00234EE4
		// (set) Token: 0x06008492 RID: 33938 RVA: 0x0003EBA8 File Offset: 0x0003CDA8
		public unsafe bool isStatic
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable.NativeFieldInfoPtr_isStatic);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable.NativeFieldInfoPtr_isStatic)) = value;
			}
		}

		// Token: 0x170027E1 RID: 10209
		// (get) Token: 0x06008493 RID: 33939 RVA: 0x00236D0C File Offset: 0x00234F0C
		// (set) Token: 0x06008494 RID: 33940 RVA: 0x0003EBC3 File Offset: 0x0003CDC3
		public unsafe string constructableName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable.NativeFieldInfoPtr_constructableName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable.NativeFieldInfoPtr_constructableName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170027E2 RID: 10210
		// (get) Token: 0x06008495 RID: 33941 RVA: 0x00236D34 File Offset: 0x00234F34
		// (set) Token: 0x06008496 RID: 33942 RVA: 0x0003EBE2 File Offset: 0x0003CDE2
		public unsafe string constructableDescription
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable.NativeFieldInfoPtr_constructableDescription);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable.NativeFieldInfoPtr_constructableDescription), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170027E3 RID: 10211
		// (get) Token: 0x06008497 RID: 33943 RVA: 0x00236D5C File Offset: 0x00234F5C
		// (set) Token: 0x06008498 RID: 33944 RVA: 0x0003EC01 File Offset: 0x0003CE01
		public unsafe string constructableAssetPath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable.NativeFieldInfoPtr_constructableAssetPath);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable.NativeFieldInfoPtr_constructableAssetPath), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170027E4 RID: 10212
		// (get) Token: 0x06008499 RID: 33945 RVA: 0x00236D84 File Offset: 0x00234F84
		// (set) Token: 0x0600849A RID: 33946 RVA: 0x0003EC20 File Offset: 0x0003CE20
		public unsafe string ID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable.NativeFieldInfoPtr_ID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable.NativeFieldInfoPtr_ID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170027E5 RID: 10213
		// (get) Token: 0x0600849B RID: 33947 RVA: 0x00236DAC File Offset: 0x00234FAC
		// (set) Token: 0x0600849C RID: 33948 RVA: 0x0003EC3F File Offset: 0x0003CE3F
		public unsafe Sprite constructableIcon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable.NativeFieldInfoPtr_constructableIcon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable.NativeFieldInfoPtr_constructableIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170027E6 RID: 10214
		// (get) Token: 0x0600849D RID: 33949 RVA: 0x00236DDC File Offset: 0x00234FDC
		// (set) Token: 0x0600849E RID: 33950 RVA: 0x0003EC5E File Offset: 0x0003CE5E
		public unsafe BoxCollider boundingBox
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable.NativeFieldInfoPtr_boundingBox);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoxCollider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable.NativeFieldInfoPtr_boundingBox), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170027E7 RID: 10215
		// (get) Token: 0x0600849F RID: 33951 RVA: 0x00236E0C File Offset: 0x0023500C
		// (set) Token: 0x060084A0 RID: 33952 RVA: 0x0003EC7D File Offset: 0x0003CE7D
		public unsafe GameObject constructionHandler_Asset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable.NativeFieldInfoPtr_constructionHandler_Asset);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable.NativeFieldInfoPtr_constructionHandler_Asset), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170027E8 RID: 10216
		// (get) Token: 0x060084A1 RID: 33953 RVA: 0x00236E3C File Offset: 0x0023503C
		// (set) Token: 0x060084A2 RID: 33954 RVA: 0x0003EC9C File Offset: 0x0003CE9C
		public unsafe List<GameObject> outlineRenderers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable.NativeFieldInfoPtr_outlineRenderers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable.NativeFieldInfoPtr_outlineRenderers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170027E9 RID: 10217
		// (get) Token: 0x060084A3 RID: 33955 RVA: 0x00236E6C File Offset: 0x0023506C
		// (set) Token: 0x060084A4 RID: 33956 RVA: 0x0003ECBB File Offset: 0x0003CEBB
		public unsafe Outlinable outlineEffect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable.NativeFieldInfoPtr_outlineEffect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Outlinable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable.NativeFieldInfoPtr_outlineEffect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170027EA RID: 10218
		// (get) Token: 0x060084A5 RID: 33957 RVA: 0x00236E9C File Offset: 0x0023509C
		// (set) Token: 0x060084A6 RID: 33958 RVA: 0x0003ECDA File Offset: 0x0003CEDA
		public unsafe List<Feature> features
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable.NativeFieldInfoPtr_features);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Feature>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable.NativeFieldInfoPtr_features), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170027EB RID: 10219
		// (get) Token: 0x060084A7 RID: 33959 RVA: 0x00236ECC File Offset: 0x002350CC
		// (set) Token: 0x060084A8 RID: 33960 RVA: 0x0003ECF9 File Offset: 0x0003CEF9
		public unsafe bool _isVisible_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable.NativeFieldInfoPtr__isVisible_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable.NativeFieldInfoPtr__isVisible_k__BackingField)) = value;
			}
		}

		// Token: 0x170027EC RID: 10220
		// (get) Token: 0x060084A9 RID: 33961 RVA: 0x00236EF4 File Offset: 0x002350F4
		// (set) Token: 0x060084AA RID: 33962 RVA: 0x0003ED14 File Offset: 0x0003CF14
		public unsafe bool isDestroyed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable.NativeFieldInfoPtr_isDestroyed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable.NativeFieldInfoPtr_isDestroyed)) = value;
			}
		}

		// Token: 0x170027ED RID: 10221
		// (get) Token: 0x060084AB RID: 33963 RVA: 0x00236F1C File Offset: 0x0023511C
		// (set) Token: 0x060084AC RID: 33964 RVA: 0x0003ED2F File Offset: 0x0003CF2F
		public unsafe Dictionary<Transform, LayerMask> originalLayers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable.NativeFieldInfoPtr_originalLayers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Transform, LayerMask>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable.NativeFieldInfoPtr_originalLayers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170027EE RID: 10222
		// (get) Token: 0x060084AD RID: 33965 RVA: 0x00236F4C File Offset: 0x0023514C
		// (set) Token: 0x060084AE RID: 33966 RVA: 0x0003ED4E File Offset: 0x0003CF4E
		public unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x170027EF RID: 10223
		// (get) Token: 0x060084AF RID: 33967 RVA: 0x00236F74 File Offset: 0x00235174
		// (set) Token: 0x060084B0 RID: 33968 RVA: 0x0003ED69 File Offset: 0x0003CF69
		public unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04005A18 RID: 23064
		private static readonly IntPtr NativeFieldInfoPtr_isStatic;

		// Token: 0x04005A19 RID: 23065
		private static readonly IntPtr NativeFieldInfoPtr_constructableName;

		// Token: 0x04005A1A RID: 23066
		private static readonly IntPtr NativeFieldInfoPtr_constructableDescription;

		// Token: 0x04005A1B RID: 23067
		private static readonly IntPtr NativeFieldInfoPtr_constructableAssetPath;

		// Token: 0x04005A1C RID: 23068
		private static readonly IntPtr NativeFieldInfoPtr_ID;

		// Token: 0x04005A1D RID: 23069
		private static readonly IntPtr NativeFieldInfoPtr_constructableIcon;

		// Token: 0x04005A1E RID: 23070
		private static readonly IntPtr NativeFieldInfoPtr_boundingBox;

		// Token: 0x04005A1F RID: 23071
		private static readonly IntPtr NativeFieldInfoPtr_constructionHandler_Asset;

		// Token: 0x04005A20 RID: 23072
		private static readonly IntPtr NativeFieldInfoPtr_outlineRenderers;

		// Token: 0x04005A21 RID: 23073
		private static readonly IntPtr NativeFieldInfoPtr_outlineEffect;

		// Token: 0x04005A22 RID: 23074
		private static readonly IntPtr NativeFieldInfoPtr_features;

		// Token: 0x04005A23 RID: 23075
		private static readonly IntPtr NativeFieldInfoPtr__isVisible_k__BackingField;

		// Token: 0x04005A24 RID: 23076
		private static readonly IntPtr NativeFieldInfoPtr_isDestroyed;

		// Token: 0x04005A25 RID: 23077
		private static readonly IntPtr NativeFieldInfoPtr_originalLayers;

		// Token: 0x04005A26 RID: 23078
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04005A27 RID: 23079
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04005A28 RID: 23080
		private static readonly IntPtr NativeMethodInfoPtr_get_IsStatic_Public_get_Boolean_0;

		// Token: 0x04005A29 RID: 23081
		private static readonly IntPtr NativeMethodInfoPtr_get_ConstructableName_Public_get_String_0;

		// Token: 0x04005A2A RID: 23082
		private static readonly IntPtr NativeMethodInfoPtr_get_ConstructableDescription_Public_get_String_0;

		// Token: 0x04005A2B RID: 23083
		private static readonly IntPtr NativeMethodInfoPtr_get_ConstructableAssetPath_Public_get_String_0;

		// Token: 0x04005A2C RID: 23084
		private static readonly IntPtr NativeMethodInfoPtr_get_PrefabID_Public_get_String_0;

		// Token: 0x04005A2D RID: 23085
		private static readonly IntPtr NativeMethodInfoPtr_get_ConstructableIcon_Public_get_Sprite_0;

		// Token: 0x04005A2E RID: 23086
		private static readonly IntPtr NativeMethodInfoPtr_get__constructionHandler_Asset_Public_get_GameObject_0;

		// Token: 0x04005A2F RID: 23087
		private static readonly IntPtr NativeMethodInfoPtr_get_isVisible_Public_get_Boolean_0;

		// Token: 0x04005A30 RID: 23088
		private static readonly IntPtr NativeMethodInfoPtr_set_isVisible_Protected_set_Void_Boolean_0;

		// Token: 0x04005A31 RID: 23089
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x04005A32 RID: 23090
		private static readonly IntPtr NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_0;

		// Token: 0x04005A33 RID: 23091
		private static readonly IntPtr NativeMethodInfoPtr_CanBeDestroyed_Public_Virtual_New_Boolean_byref_String_0;

		// Token: 0x04005A34 RID: 23092
		private static readonly IntPtr NativeMethodInfoPtr_CanBeDestroyed_Public_Virtual_New_Boolean_0;

		// Token: 0x04005A35 RID: 23093
		private static readonly IntPtr NativeMethodInfoPtr_DestroyConstructable_Public_Virtual_New_Void_Boolean_0;

		// Token: 0x04005A36 RID: 23094
		private static readonly IntPtr NativeMethodInfoPtr_Destroy_Networked_Private_Void_0;

		// Token: 0x04005A37 RID: 23095
		private static readonly IntPtr NativeMethodInfoPtr_DestroyConstructableWrapper_Private_Void_0;

		// Token: 0x04005A38 RID: 23096
		private static readonly IntPtr NativeMethodInfoPtr_CanBeModified_Public_Virtual_New_Boolean_0;

		// Token: 0x04005A39 RID: 23097
		private static readonly IntPtr NativeMethodInfoPtr_CanBePickedUpByHand_Public_Virtual_New_Boolean_0;

		// Token: 0x04005A3A RID: 23098
		private static readonly IntPtr NativeMethodInfoPtr_CanBeSelected_Public_Virtual_New_Boolean_0;

		// Token: 0x04005A3B RID: 23099
		private static readonly IntPtr NativeMethodInfoPtr_GetBuildableVersionAssetPath_Public_Virtual_New_String_0;

		// Token: 0x04005A3C RID: 23100
		private static readonly IntPtr NativeMethodInfoPtr_ShowOutline_Public_Void_EOutlineColor_0;

		// Token: 0x04005A3D RID: 23101
		private static readonly IntPtr NativeMethodInfoPtr_HideOutline_Public_Void_0;

		// Token: 0x04005A3E RID: 23102
		private static readonly IntPtr NativeMethodInfoPtr_GetCosmeticCenter_Public_Virtual_New_Vector3_0;

		// Token: 0x04005A3F RID: 23103
		private static readonly IntPtr NativeMethodInfoPtr_GetBoundingBoxLongestSide_Public_Single_0;

		// Token: 0x04005A40 RID: 23104
		private static readonly IntPtr NativeMethodInfoPtr_SetInvisible_Public_Virtual_New_Void_0;

		// Token: 0x04005A41 RID: 23105
		private static readonly IntPtr NativeMethodInfoPtr_RestoreVisibility_Public_Virtual_New_Void_0;

		// Token: 0x04005A42 RID: 23106
		private static readonly IntPtr NativeMethodInfoPtr_SetLayerRecursively_Public_Void_GameObject_Int32_0;

		// Token: 0x04005A43 RID: 23107
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04005A44 RID: 23108
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04005A45 RID: 23109
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04005A46 RID: 23110
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04005A47 RID: 23111
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_Destroy_Networked_2166136261_Private_Void_0;

		// Token: 0x04005A48 RID: 23112
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___Destroy_Networked_2166136261_Private_Void_0;

		// Token: 0x04005A49 RID: 23113
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_Destroy_Networked_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04005A4A RID: 23114
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_DestroyConstructableWrapper_2166136261_Private_Void_0;

		// Token: 0x04005A4B RID: 23115
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___DestroyConstructableWrapper_2166136261_Private_Void_0;

		// Token: 0x04005A4C RID: 23116
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_DestroyConstructableWrapper_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x04005A4D RID: 23117
		private static readonly IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0;
	}
}
