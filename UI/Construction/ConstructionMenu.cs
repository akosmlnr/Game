using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ConstructableScripts;
using Il2CppScheduleOne.DevUtilities;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Construction
{
	// Token: 0x02000749 RID: 1865
	public class ConstructionMenu : Singleton<ConstructionMenu>
	{
		// Token: 0x0600A709 RID: 42761 RVA: 0x0029FC44 File Offset: 0x0029DE44
		// Note: this type is marked as 'beforefieldinit'.
		static ConstructionMenu()
		{
			Il2CppClassPointerStore<ConstructionMenu>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Construction", "ConstructionMenu");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConstructionMenu>.NativeClassPtr);
			ConstructionMenu.NativeFieldInfoPtr__isOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructionMenu>.NativeClassPtr, "<isOpen>k__BackingField");
			ConstructionMenu.NativeFieldInfoPtr_categories = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructionMenu>.NativeClassPtr, "categories");
			ConstructionMenu.NativeFieldInfoPtr_canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructionMenu>.NativeClassPtr, "canvas");
			ConstructionMenu.NativeFieldInfoPtr_raycaster = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructionMenu>.NativeClassPtr, "raycaster");
			ConstructionMenu.NativeFieldInfoPtr_categoryButtonContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructionMenu>.NativeClassPtr, "categoryButtonContainer");
			ConstructionMenu.NativeFieldInfoPtr_categoryContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructionMenu>.NativeClassPtr, "categoryContainer");
			ConstructionMenu.NativeFieldInfoPtr_categoryNameDisplay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructionMenu>.NativeClassPtr, "categoryNameDisplay");
			ConstructionMenu.NativeFieldInfoPtr_infoPopup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructionMenu>.NativeClassPtr, "infoPopup");
			ConstructionMenu.NativeFieldInfoPtr_infoPopup_ConstructableName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructionMenu>.NativeClassPtr, "infoPopup_ConstructableName");
			ConstructionMenu.NativeFieldInfoPtr_eventSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructionMenu>.NativeClassPtr, "eventSystem");
			ConstructionMenu.NativeFieldInfoPtr_destroyButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructionMenu>.NativeClassPtr, "destroyButton");
			ConstructionMenu.NativeFieldInfoPtr_customizeButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructionMenu>.NativeClassPtr, "customizeButton");
			ConstructionMenu.NativeFieldInfoPtr_moveButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructionMenu>.NativeClassPtr, "moveButton");
			ConstructionMenu.NativeFieldInfoPtr_infoPopup_Description = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructionMenu>.NativeClassPtr, "infoPopup_Description");
			ConstructionMenu.NativeFieldInfoPtr_categoryButtonPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructionMenu>.NativeClassPtr, "categoryButtonPrefab");
			ConstructionMenu.NativeFieldInfoPtr_categoryContainerPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructionMenu>.NativeClassPtr, "categoryContainerPrefab");
			ConstructionMenu.NativeFieldInfoPtr_listingPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructionMenu>.NativeClassPtr, "listingPrefab");
			ConstructionMenu.NativeFieldInfoPtr_iconColor_Unselected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructionMenu>.NativeClassPtr, "iconColor_Unselected");
			ConstructionMenu.NativeFieldInfoPtr_iconColor_Selected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructionMenu>.NativeClassPtr, "iconColor_Selected");
			ConstructionMenu.NativeFieldInfoPtr_listingOutlineColor_Unselected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructionMenu>.NativeClassPtr, "listingOutlineColor_Unselected");
			ConstructionMenu.NativeFieldInfoPtr_listingOutlineColor_Selected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructionMenu>.NativeClassPtr, "listingOutlineColor_Selected");
			ConstructionMenu.NativeFieldInfoPtr_selectedCategory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructionMenu>.NativeClassPtr, "selectedCategory");
			ConstructionMenu.NativeFieldInfoPtr_selectedListing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructionMenu>.NativeClassPtr, "selectedListing");
			ConstructionMenu.NativeFieldInfoPtr_selectedConstructable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructionMenu>.NativeClassPtr, "selectedConstructable");
			ConstructionMenu.NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionMenu>.NativeClassPtr, 100683815);
			ConstructionMenu.NativeMethodInfoPtr_set_isOpen_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionMenu>.NativeClassPtr, 100683816);
			ConstructionMenu.NativeMethodInfoPtr_get_SelectedConstructable_Public_get_Constructable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionMenu>.NativeClassPtr, 100683817);
			ConstructionMenu.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionMenu>.NativeClassPtr, 100683818);
			ConstructionMenu.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionMenu>.NativeClassPtr, 100683819);
			ConstructionMenu.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionMenu>.NativeClassPtr, 100683820);
			ConstructionMenu.NativeMethodInfoPtr_SetupListings_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionMenu>.NativeClassPtr, 100683821);
			ConstructionMenu.NativeMethodInfoPtr_AddListing_Private_Void_String_Single_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionMenu>.NativeClassPtr, 100683822);
			ConstructionMenu.NativeMethodInfoPtr_SetIsOpen_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionMenu>.NativeClassPtr, 100683823);
			ConstructionMenu.NativeMethodInfoPtr_OnConstructableBuilt_Private_Void_Constructable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionMenu>.NativeClassPtr, 100683824);
			ConstructionMenu.NativeMethodInfoPtr_ClearSelectedListing_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionMenu>.NativeClassPtr, 100683825);
			ConstructionMenu.NativeMethodInfoPtr_ListingClicked_Public_Void_ConstructionMenuListing_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionMenu>.NativeClassPtr, 100683826);
			ConstructionMenu.NativeMethodInfoPtr_IsHoveringUI_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionMenu>.NativeClassPtr, 100683827);
			ConstructionMenu.NativeMethodInfoPtr_MoveButtonPressed_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionMenu>.NativeClassPtr, 100683828);
			ConstructionMenu.NativeMethodInfoPtr_CustomizeButtonPressed_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionMenu>.NativeClassPtr, 100683829);
			ConstructionMenu.NativeMethodInfoPtr_BulldozeButtonPressed_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionMenu>.NativeClassPtr, 100683830);
			ConstructionMenu.NativeMethodInfoPtr_CheckConstructableSelection_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionMenu>.NativeClassPtr, 100683831);
			ConstructionMenu.NativeMethodInfoPtr_SelectConstructable_Public_Void_Constructable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionMenu>.NativeClassPtr, 100683832);
			ConstructionMenu.NativeMethodInfoPtr_SelectConstructable_Public_Void_Constructable_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionMenu>.NativeClassPtr, 100683833);
			ConstructionMenu.NativeMethodInfoPtr_SetButtonInteractable_Private_Void_Button_Boolean_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionMenu>.NativeClassPtr, 100683834);
			ConstructionMenu.NativeMethodInfoPtr_DeselectConstructable_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionMenu>.NativeClassPtr, 100683835);
			ConstructionMenu.NativeMethodInfoPtr_GetHoveredConstructable_Private_Constructable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionMenu>.NativeClassPtr, 100683836);
			ConstructionMenu.NativeMethodInfoPtr_GenerateCategories_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionMenu>.NativeClassPtr, 100683837);
			ConstructionMenu.NativeMethodInfoPtr_SelectCategory_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionMenu>.NativeClassPtr, 100683838);
			ConstructionMenu.NativeMethodInfoPtr_GetListingPrice_Public_Single_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionMenu>.NativeClassPtr, 100683839);
			ConstructionMenu.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionMenu>.NativeClassPtr, 100683840);
			ConstructionMenu.NativeMethodInfoPtr__Start_b__31_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionMenu>.NativeClassPtr, 100683841);
			ConstructionMenu.NativeMethodInfoPtr__Start_b__31_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionMenu>.NativeClassPtr, 100683842);
		}

		// Token: 0x1700336B RID: 13163
		// (get) Token: 0x0600A70A RID: 42762 RVA: 0x002A0084 File Offset: 0x0029E284
		// (set) Token: 0x0600A70B RID: 42763 RVA: 0x002A00C0 File Offset: 0x0029E2C0
		public unsafe bool isOpen
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(ConstructionMenu.NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(19)]
			[CachedScanResults(RefRangeStart = 40119, RefRangeEnd = 40138, XrefRangeStart = 40119, XrefRangeEnd = 40138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref value;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionMenu.NativeMethodInfoPtr_set_isOpen_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x1700336C RID: 13164
		// (get) Token: 0x0600A70C RID: 42764 RVA: 0x002A0100 File Offset: 0x0029E300
		public unsafe Constructable SelectedConstructable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionMenu.NativeMethodInfoPtr_get_SelectedConstructable_Public_get_Constructable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Constructable>(intPtr2) : null;
			}
		}

		// Token: 0x0600A70D RID: 42765 RVA: 0x002A0140 File Offset: 0x0029E340
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292027, XrefRangeEnd = 292124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConstructionMenu.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A70E RID: 42766 RVA: 0x002A017C File Offset: 0x0029E37C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292124, XrefRangeEnd = 292130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Exit(ExitAction exit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(exit);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionMenu.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A70F RID: 42767 RVA: 0x002A01C0 File Offset: 0x0029E3C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292130, XrefRangeEnd = 292131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConstructionMenu.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A710 RID: 42768 RVA: 0x002A01FC File Offset: 0x0029E3FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292131, XrefRangeEnd = 292136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetupListings()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionMenu.NativeMethodInfoPtr_SetupListings_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A711 RID: 42769 RVA: 0x002A0230 File Offset: 0x0029E430
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 292179, RefRangeEnd = 292181, XrefRangeStart = 292136, XrefRangeEnd = 292179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddListing(string ID, float price, string category)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(ID);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref price;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(category);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionMenu.NativeMethodInfoPtr_AddListing_Private_Void_String_Single_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A712 RID: 42770 RVA: 0x002A0294 File Offset: 0x0029E494
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 292198, RefRangeEnd = 292199, XrefRangeStart = 292181, XrefRangeEnd = 292198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIsOpen(bool open)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref open;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionMenu.NativeMethodInfoPtr_SetIsOpen_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A713 RID: 42771 RVA: 0x002A02D4 File Offset: 0x0029E4D4
		[CallerCount(14558)]
		[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnConstructableBuilt(Constructable c)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionMenu.NativeMethodInfoPtr_OnConstructableBuilt_Private_Void_Constructable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A714 RID: 42772 RVA: 0x002A0318 File Offset: 0x0029E518
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 292206, RefRangeEnd = 292212, XrefRangeStart = 292199, XrefRangeEnd = 292206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearSelectedListing()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionMenu.NativeMethodInfoPtr_ClearSelectedListing_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A715 RID: 42773 RVA: 0x002A034C File Offset: 0x0029E54C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292212, XrefRangeEnd = 292221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ListingClicked(ConstructionMenu.ConstructionMenuListing listing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(listing);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionMenu.NativeMethodInfoPtr_ListingClicked_Public_Void_ConstructionMenuListing_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A716 RID: 42774 RVA: 0x002A0390 File Offset: 0x0029E590
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 292233, RefRangeEnd = 292234, XrefRangeStart = 292221, XrefRangeEnd = 292233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsHoveringUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(ConstructionMenu.NativeMethodInfoPtr_IsHoveringUI_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600A717 RID: 42775 RVA: 0x002A03CC File Offset: 0x0029E5CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292234, XrefRangeEnd = 292246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MoveButtonPressed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionMenu.NativeMethodInfoPtr_MoveButtonPressed_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A718 RID: 42776 RVA: 0x002A0400 File Offset: 0x0029E600
		[CallerCount(14558)]
		[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CustomizeButtonPressed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionMenu.NativeMethodInfoPtr_CustomizeButtonPressed_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A719 RID: 42777 RVA: 0x002A0434 File Offset: 0x0029E634
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292246, XrefRangeEnd = 292253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BulldozeButtonPressed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionMenu.NativeMethodInfoPtr_BulldozeButtonPressed_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A71A RID: 42778 RVA: 0x002A0468 File Offset: 0x0029E668
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 292293, RefRangeEnd = 292294, XrefRangeStart = 292253, XrefRangeEnd = 292293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckConstructableSelection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionMenu.NativeMethodInfoPtr_CheckConstructableSelection_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A71B RID: 42779 RVA: 0x002A049C File Offset: 0x0029E69C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292294, XrefRangeEnd = 292295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SelectConstructable(Constructable c)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionMenu.NativeMethodInfoPtr_SelectConstructable_Public_Void_Constructable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A71C RID: 42780 RVA: 0x002A04E0 File Offset: 0x0029E6E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 292369, RefRangeEnd = 292370, XrefRangeStart = 292295, XrefRangeEnd = 292369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SelectConstructable(Constructable c, bool focusCameraTo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref focusCameraTo;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionMenu.NativeMethodInfoPtr_SelectConstructable_Public_Void_Constructable_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A71D RID: 42781 RVA: 0x002A0530 File Offset: 0x0029E730
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 292378, RefRangeEnd = 292380, XrefRangeStart = 292370, XrefRangeEnd = 292378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetButtonInteractable(Button b, bool interactable, Color32 iconDefaultColor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(b);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref interactable;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref iconDefaultColor;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionMenu.NativeMethodInfoPtr_SetButtonInteractable_Private_Void_Button_Boolean_Color32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A71E RID: 42782 RVA: 0x002A0590 File Offset: 0x0029E790
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 292395, RefRangeEnd = 292403, XrefRangeStart = 292380, XrefRangeEnd = 292395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DeselectConstructable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionMenu.NativeMethodInfoPtr_DeselectConstructable_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A71F RID: 42783 RVA: 0x002A05C4 File Offset: 0x0029E7C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292403, XrefRangeEnd = 292413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Constructable GetHoveredConstructable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionMenu.NativeMethodInfoPtr_GetHoveredConstructable_Private_Constructable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Constructable>(intPtr2) : null;
		}

		// Token: 0x0600A720 RID: 42784 RVA: 0x002A0604 File Offset: 0x0029E804
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 292476, RefRangeEnd = 292477, XrefRangeStart = 292413, XrefRangeEnd = 292476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GenerateCategories()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionMenu.NativeMethodInfoPtr_GenerateCategories_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A721 RID: 42785 RVA: 0x002A0638 File Offset: 0x0029E838
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 292512, RefRangeEnd = 292514, XrefRangeStart = 292477, XrefRangeEnd = 292512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SelectCategory(string categoryName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(categoryName);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionMenu.NativeMethodInfoPtr_SelectCategory_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A722 RID: 42786 RVA: 0x002A067C File Offset: 0x0029E87C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 292533, RefRangeEnd = 292536, XrefRangeStart = 292514, XrefRangeEnd = 292533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetListingPrice(string id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(ConstructionMenu.NativeMethodInfoPtr_GetListingPrice_Public_Single_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600A723 RID: 42787 RVA: 0x002A06CC File Offset: 0x0029E8CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292536, XrefRangeEnd = 292546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConstructionMenu() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConstructionMenu>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionMenu.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A724 RID: 42788 RVA: 0x002A0708 File Offset: 0x0029E908
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292546, XrefRangeEnd = 292547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Start_b__31_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionMenu.NativeMethodInfoPtr__Start_b__31_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A725 RID: 42789 RVA: 0x002A073C File Offset: 0x0029E93C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292547, XrefRangeEnd = 292558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Start_b__31_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionMenu.NativeMethodInfoPtr__Start_b__31_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A726 RID: 42790 RVA: 0x00052188 File Offset: 0x00050388
		public ConstructionMenu(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003353 RID: 13139
		// (get) Token: 0x0600A727 RID: 42791 RVA: 0x002A0770 File Offset: 0x0029E970
		// (set) Token: 0x0600A728 RID: 42792 RVA: 0x00052191 File Offset: 0x00050391
		public unsafe bool _isOpen_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.NativeFieldInfoPtr__isOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.NativeFieldInfoPtr__isOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x17003354 RID: 13140
		// (get) Token: 0x0600A729 RID: 42793 RVA: 0x002A0798 File Offset: 0x0029E998
		// (set) Token: 0x0600A72A RID: 42794 RVA: 0x000521AC File Offset: 0x000503AC
		public unsafe List<ConstructionMenu.ConstructionMenuCategory> categories
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.NativeFieldInfoPtr_categories);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ConstructionMenu.ConstructionMenuCategory>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.NativeFieldInfoPtr_categories), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003355 RID: 13141
		// (get) Token: 0x0600A72B RID: 42795 RVA: 0x002A07C8 File Offset: 0x0029E9C8
		// (set) Token: 0x0600A72C RID: 42796 RVA: 0x000521CB File Offset: 0x000503CB
		public unsafe Canvas canvas
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.NativeFieldInfoPtr_canvas);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.NativeFieldInfoPtr_canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003356 RID: 13142
		// (get) Token: 0x0600A72D RID: 42797 RVA: 0x002A07F8 File Offset: 0x0029E9F8
		// (set) Token: 0x0600A72E RID: 42798 RVA: 0x000521EA File Offset: 0x000503EA
		public unsafe GraphicRaycaster raycaster
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.NativeFieldInfoPtr_raycaster);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GraphicRaycaster>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.NativeFieldInfoPtr_raycaster), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003357 RID: 13143
		// (get) Token: 0x0600A72F RID: 42799 RVA: 0x002A0828 File Offset: 0x0029EA28
		// (set) Token: 0x0600A730 RID: 42800 RVA: 0x00052209 File Offset: 0x00050409
		public unsafe Transform categoryButtonContainer
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.NativeFieldInfoPtr_categoryButtonContainer);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.NativeFieldInfoPtr_categoryButtonContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003358 RID: 13144
		// (get) Token: 0x0600A731 RID: 42801 RVA: 0x002A0858 File Offset: 0x0029EA58
		// (set) Token: 0x0600A732 RID: 42802 RVA: 0x00052228 File Offset: 0x00050428
		public unsafe RectTransform categoryContainer
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.NativeFieldInfoPtr_categoryContainer);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.NativeFieldInfoPtr_categoryContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003359 RID: 13145
		// (get) Token: 0x0600A733 RID: 42803 RVA: 0x002A0888 File Offset: 0x0029EA88
		// (set) Token: 0x0600A734 RID: 42804 RVA: 0x00052247 File Offset: 0x00050447
		public unsafe Text categoryNameDisplay
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.NativeFieldInfoPtr_categoryNameDisplay);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.NativeFieldInfoPtr_categoryNameDisplay), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700335A RID: 13146
		// (get) Token: 0x0600A735 RID: 42805 RVA: 0x002A08B8 File Offset: 0x0029EAB8
		// (set) Token: 0x0600A736 RID: 42806 RVA: 0x00052266 File Offset: 0x00050466
		public unsafe RectTransform infoPopup
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.NativeFieldInfoPtr_infoPopup);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.NativeFieldInfoPtr_infoPopup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700335B RID: 13147
		// (get) Token: 0x0600A737 RID: 42807 RVA: 0x002A08E8 File Offset: 0x0029EAE8
		// (set) Token: 0x0600A738 RID: 42808 RVA: 0x00052285 File Offset: 0x00050485
		public unsafe TextMeshProUGUI infoPopup_ConstructableName
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.NativeFieldInfoPtr_infoPopup_ConstructableName);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.NativeFieldInfoPtr_infoPopup_ConstructableName), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700335C RID: 13148
		// (get) Token: 0x0600A739 RID: 42809 RVA: 0x002A0918 File Offset: 0x0029EB18
		// (set) Token: 0x0600A73A RID: 42810 RVA: 0x000522A4 File Offset: 0x000504A4
		public unsafe EventSystem eventSystem
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.NativeFieldInfoPtr_eventSystem);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventSystem>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.NativeFieldInfoPtr_eventSystem), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700335D RID: 13149
		// (get) Token: 0x0600A73B RID: 42811 RVA: 0x002A0948 File Offset: 0x0029EB48
		// (set) Token: 0x0600A73C RID: 42812 RVA: 0x000522C3 File Offset: 0x000504C3
		public unsafe Button destroyButton
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.NativeFieldInfoPtr_destroyButton);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.NativeFieldInfoPtr_destroyButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700335E RID: 13150
		// (get) Token: 0x0600A73D RID: 42813 RVA: 0x002A0978 File Offset: 0x0029EB78
		// (set) Token: 0x0600A73E RID: 42814 RVA: 0x000522E2 File Offset: 0x000504E2
		public unsafe Button customizeButton
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.NativeFieldInfoPtr_customizeButton);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.NativeFieldInfoPtr_customizeButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700335F RID: 13151
		// (get) Token: 0x0600A73F RID: 42815 RVA: 0x002A09A8 File Offset: 0x0029EBA8
		// (set) Token: 0x0600A740 RID: 42816 RVA: 0x00052301 File Offset: 0x00050501
		public unsafe Button moveButton
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.NativeFieldInfoPtr_moveButton);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.NativeFieldInfoPtr_moveButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003360 RID: 13152
		// (get) Token: 0x0600A741 RID: 42817 RVA: 0x002A09D8 File Offset: 0x0029EBD8
		// (set) Token: 0x0600A742 RID: 42818 RVA: 0x00052320 File Offset: 0x00050520
		public unsafe TextMeshProUGUI infoPopup_Description
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.NativeFieldInfoPtr_infoPopup_Description);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.NativeFieldInfoPtr_infoPopup_Description), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003361 RID: 13153
		// (get) Token: 0x0600A743 RID: 42819 RVA: 0x002A0A08 File Offset: 0x0029EC08
		// (set) Token: 0x0600A744 RID: 42820 RVA: 0x0005233F File Offset: 0x0005053F
		public unsafe GameObject categoryButtonPrefab
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.NativeFieldInfoPtr_categoryButtonPrefab);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.NativeFieldInfoPtr_categoryButtonPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003362 RID: 13154
		// (get) Token: 0x0600A745 RID: 42821 RVA: 0x002A0A38 File Offset: 0x0029EC38
		// (set) Token: 0x0600A746 RID: 42822 RVA: 0x0005235E File Offset: 0x0005055E
		public unsafe GameObject categoryContainerPrefab
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.NativeFieldInfoPtr_categoryContainerPrefab);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.NativeFieldInfoPtr_categoryContainerPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003363 RID: 13155
		// (get) Token: 0x0600A747 RID: 42823 RVA: 0x002A0A68 File Offset: 0x0029EC68
		// (set) Token: 0x0600A748 RID: 42824 RVA: 0x0005237D File Offset: 0x0005057D
		public unsafe GameObject listingPrefab
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.NativeFieldInfoPtr_listingPrefab);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.NativeFieldInfoPtr_listingPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003364 RID: 13156
		// (get) Token: 0x0600A749 RID: 42825 RVA: 0x002A0A98 File Offset: 0x0029EC98
		// (set) Token: 0x0600A74A RID: 42826 RVA: 0x0005239C File Offset: 0x0005059C
		public unsafe Color iconColor_Unselected
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.NativeFieldInfoPtr_iconColor_Unselected);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.NativeFieldInfoPtr_iconColor_Unselected)) = value;
			}
		}

		// Token: 0x17003365 RID: 13157
		// (get) Token: 0x0600A74B RID: 42827 RVA: 0x002A0AC0 File Offset: 0x0029ECC0
		// (set) Token: 0x0600A74C RID: 42828 RVA: 0x000523B7 File Offset: 0x000505B7
		public unsafe Color iconColor_Selected
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.NativeFieldInfoPtr_iconColor_Selected);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.NativeFieldInfoPtr_iconColor_Selected)) = value;
			}
		}

		// Token: 0x17003366 RID: 13158
		// (get) Token: 0x0600A74D RID: 42829 RVA: 0x002A0AE8 File Offset: 0x0029ECE8
		// (set) Token: 0x0600A74E RID: 42830 RVA: 0x000523D2 File Offset: 0x000505D2
		public unsafe Color listingOutlineColor_Unselected
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.NativeFieldInfoPtr_listingOutlineColor_Unselected);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.NativeFieldInfoPtr_listingOutlineColor_Unselected)) = value;
			}
		}

		// Token: 0x17003367 RID: 13159
		// (get) Token: 0x0600A74F RID: 42831 RVA: 0x002A0B10 File Offset: 0x0029ED10
		// (set) Token: 0x0600A750 RID: 42832 RVA: 0x000523ED File Offset: 0x000505ED
		public unsafe Color listingOutlineColor_Selected
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.NativeFieldInfoPtr_listingOutlineColor_Selected);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.NativeFieldInfoPtr_listingOutlineColor_Selected)) = value;
			}
		}

		// Token: 0x17003368 RID: 13160
		// (get) Token: 0x0600A751 RID: 42833 RVA: 0x002A0B38 File Offset: 0x0029ED38
		// (set) Token: 0x0600A752 RID: 42834 RVA: 0x00052408 File Offset: 0x00050608
		public unsafe ConstructionMenu.ConstructionMenuCategory selectedCategory
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.NativeFieldInfoPtr_selectedCategory);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConstructionMenu.ConstructionMenuCategory>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.NativeFieldInfoPtr_selectedCategory), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003369 RID: 13161
		// (get) Token: 0x0600A753 RID: 42835 RVA: 0x002A0B68 File Offset: 0x0029ED68
		// (set) Token: 0x0600A754 RID: 42836 RVA: 0x00052427 File Offset: 0x00050627
		public unsafe ConstructionMenu.ConstructionMenuListing selectedListing
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.NativeFieldInfoPtr_selectedListing);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConstructionMenu.ConstructionMenuListing>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.NativeFieldInfoPtr_selectedListing), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700336A RID: 13162
		// (get) Token: 0x0600A755 RID: 42837 RVA: 0x002A0B98 File Offset: 0x0029ED98
		// (set) Token: 0x0600A756 RID: 42838 RVA: 0x00052446 File Offset: 0x00050646
		public unsafe Constructable selectedConstructable
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.NativeFieldInfoPtr_selectedConstructable);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Constructable>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.NativeFieldInfoPtr_selectedConstructable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04007000 RID: 28672
		private static readonly System.IntPtr NativeFieldInfoPtr__isOpen_k__BackingField;

		// Token: 0x04007001 RID: 28673
		private static readonly System.IntPtr NativeFieldInfoPtr_categories;

		// Token: 0x04007002 RID: 28674
		private static readonly System.IntPtr NativeFieldInfoPtr_canvas;

		// Token: 0x04007003 RID: 28675
		private static readonly System.IntPtr NativeFieldInfoPtr_raycaster;

		// Token: 0x04007004 RID: 28676
		private static readonly System.IntPtr NativeFieldInfoPtr_categoryButtonContainer;

		// Token: 0x04007005 RID: 28677
		private static readonly System.IntPtr NativeFieldInfoPtr_categoryContainer;

		// Token: 0x04007006 RID: 28678
		private static readonly System.IntPtr NativeFieldInfoPtr_categoryNameDisplay;

		// Token: 0x04007007 RID: 28679
		private static readonly System.IntPtr NativeFieldInfoPtr_infoPopup;

		// Token: 0x04007008 RID: 28680
		private static readonly System.IntPtr NativeFieldInfoPtr_infoPopup_ConstructableName;

		// Token: 0x04007009 RID: 28681
		private static readonly System.IntPtr NativeFieldInfoPtr_eventSystem;

		// Token: 0x0400700A RID: 28682
		private static readonly System.IntPtr NativeFieldInfoPtr_destroyButton;

		// Token: 0x0400700B RID: 28683
		private static readonly System.IntPtr NativeFieldInfoPtr_customizeButton;

		// Token: 0x0400700C RID: 28684
		private static readonly System.IntPtr NativeFieldInfoPtr_moveButton;

		// Token: 0x0400700D RID: 28685
		private static readonly System.IntPtr NativeFieldInfoPtr_infoPopup_Description;

		// Token: 0x0400700E RID: 28686
		private static readonly System.IntPtr NativeFieldInfoPtr_categoryButtonPrefab;

		// Token: 0x0400700F RID: 28687
		private static readonly System.IntPtr NativeFieldInfoPtr_categoryContainerPrefab;

		// Token: 0x04007010 RID: 28688
		private static readonly System.IntPtr NativeFieldInfoPtr_listingPrefab;

		// Token: 0x04007011 RID: 28689
		private static readonly System.IntPtr NativeFieldInfoPtr_iconColor_Unselected;

		// Token: 0x04007012 RID: 28690
		private static readonly System.IntPtr NativeFieldInfoPtr_iconColor_Selected;

		// Token: 0x04007013 RID: 28691
		private static readonly System.IntPtr NativeFieldInfoPtr_listingOutlineColor_Unselected;

		// Token: 0x04007014 RID: 28692
		private static readonly System.IntPtr NativeFieldInfoPtr_listingOutlineColor_Selected;

		// Token: 0x04007015 RID: 28693
		private static readonly System.IntPtr NativeFieldInfoPtr_selectedCategory;

		// Token: 0x04007016 RID: 28694
		private static readonly System.IntPtr NativeFieldInfoPtr_selectedListing;

		// Token: 0x04007017 RID: 28695
		private static readonly System.IntPtr NativeFieldInfoPtr_selectedConstructable;

		// Token: 0x04007018 RID: 28696
		private static readonly System.IntPtr NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0;

		// Token: 0x04007019 RID: 28697
		private static readonly System.IntPtr NativeMethodInfoPtr_set_isOpen_Protected_set_Void_Boolean_0;

		// Token: 0x0400701A RID: 28698
		private static readonly System.IntPtr NativeMethodInfoPtr_get_SelectedConstructable_Public_get_Constructable_0;

		// Token: 0x0400701B RID: 28699
		private static readonly System.IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x0400701C RID: 28700
		private static readonly System.IntPtr NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0;

		// Token: 0x0400701D RID: 28701
		private static readonly System.IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x0400701E RID: 28702
		private static readonly System.IntPtr NativeMethodInfoPtr_SetupListings_Private_Void_0;

		// Token: 0x0400701F RID: 28703
		private static readonly System.IntPtr NativeMethodInfoPtr_AddListing_Private_Void_String_Single_String_0;

		// Token: 0x04007020 RID: 28704
		private static readonly System.IntPtr NativeMethodInfoPtr_SetIsOpen_Private_Void_Boolean_0;

		// Token: 0x04007021 RID: 28705
		private static readonly System.IntPtr NativeMethodInfoPtr_OnConstructableBuilt_Private_Void_Constructable_0;

		// Token: 0x04007022 RID: 28706
		private static readonly System.IntPtr NativeMethodInfoPtr_ClearSelectedListing_Public_Void_0;

		// Token: 0x04007023 RID: 28707
		private static readonly System.IntPtr NativeMethodInfoPtr_ListingClicked_Public_Void_ConstructionMenuListing_0;

		// Token: 0x04007024 RID: 28708
		private static readonly System.IntPtr NativeMethodInfoPtr_IsHoveringUI_Public_Boolean_0;

		// Token: 0x04007025 RID: 28709
		private static readonly System.IntPtr NativeMethodInfoPtr_MoveButtonPressed_Public_Void_0;

		// Token: 0x04007026 RID: 28710
		private static readonly System.IntPtr NativeMethodInfoPtr_CustomizeButtonPressed_Public_Void_0;

		// Token: 0x04007027 RID: 28711
		private static readonly System.IntPtr NativeMethodInfoPtr_BulldozeButtonPressed_Public_Void_0;

		// Token: 0x04007028 RID: 28712
		private static readonly System.IntPtr NativeMethodInfoPtr_CheckConstructableSelection_Private_Void_0;

		// Token: 0x04007029 RID: 28713
		private static readonly System.IntPtr NativeMethodInfoPtr_SelectConstructable_Public_Void_Constructable_0;

		// Token: 0x0400702A RID: 28714
		private static readonly System.IntPtr NativeMethodInfoPtr_SelectConstructable_Public_Void_Constructable_Boolean_0;

		// Token: 0x0400702B RID: 28715
		private static readonly System.IntPtr NativeMethodInfoPtr_SetButtonInteractable_Private_Void_Button_Boolean_Color32_0;

		// Token: 0x0400702C RID: 28716
		private static readonly System.IntPtr NativeMethodInfoPtr_DeselectConstructable_Public_Void_0;

		// Token: 0x0400702D RID: 28717
		private static readonly System.IntPtr NativeMethodInfoPtr_GetHoveredConstructable_Private_Constructable_0;

		// Token: 0x0400702E RID: 28718
		private static readonly System.IntPtr NativeMethodInfoPtr_GenerateCategories_Private_Void_0;

		// Token: 0x0400702F RID: 28719
		private static readonly System.IntPtr NativeMethodInfoPtr_SelectCategory_Public_Void_String_0;

		// Token: 0x04007030 RID: 28720
		private static readonly System.IntPtr NativeMethodInfoPtr_GetListingPrice_Public_Single_String_0;

		// Token: 0x04007031 RID: 28721
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04007032 RID: 28722
		private static readonly System.IntPtr NativeMethodInfoPtr__Start_b__31_0_Private_Void_0;

		// Token: 0x04007033 RID: 28723
		private static readonly System.IntPtr NativeMethodInfoPtr__Start_b__31_1_Private_Void_0;

		// Token: 0x02000C18 RID: 3096
		[System.Serializable]
		public class ConstructionMenuCategory : Il2CppSystem.Object
		{
			// Token: 0x0600E311 RID: 58129 RVA: 0x0035BEF0 File Offset: 0x0035A0F0
			// Note: this type is marked as 'beforefieldinit'.
			static ConstructionMenuCategory()
			{
				Il2CppClassPointerStore<ConstructionMenu.ConstructionMenuCategory>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ConstructionMenu>.NativeClassPtr, "ConstructionMenuCategory");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConstructionMenu.ConstructionMenuCategory>.NativeClassPtr);
				ConstructionMenu.ConstructionMenuCategory.NativeFieldInfoPtr_categoryName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructionMenu.ConstructionMenuCategory>.NativeClassPtr, "categoryName");
				ConstructionMenu.ConstructionMenuCategory.NativeFieldInfoPtr_categoryIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructionMenu.ConstructionMenuCategory>.NativeClassPtr, "categoryIcon");
				ConstructionMenu.ConstructionMenuCategory.NativeFieldInfoPtr_button = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructionMenu.ConstructionMenuCategory>.NativeClassPtr, "button");
				ConstructionMenu.ConstructionMenuCategory.NativeFieldInfoPtr_container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructionMenu.ConstructionMenuCategory>.NativeClassPtr, "container");
				ConstructionMenu.ConstructionMenuCategory.NativeFieldInfoPtr_listings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructionMenu.ConstructionMenuCategory>.NativeClassPtr, "listings");
				ConstructionMenu.ConstructionMenuCategory.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionMenu.ConstructionMenuCategory>.NativeClassPtr, 100683843);
			}

			// Token: 0x0600E312 RID: 58130 RVA: 0x0035BF94 File Offset: 0x0035A194
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291897, XrefRangeEnd = 291909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ConstructionMenuCategory() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConstructionMenu.ConstructionMenuCategory>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionMenu.ConstructionMenuCategory.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600E313 RID: 58131 RVA: 0x0006E51F File Offset: 0x0006C71F
			public ConstructionMenuCategory(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004608 RID: 17928
			// (get) Token: 0x0600E314 RID: 58132 RVA: 0x0035BFD0 File Offset: 0x0035A1D0
			// (set) Token: 0x0600E315 RID: 58133 RVA: 0x0006E528 File Offset: 0x0006C728
			public unsafe string categoryName
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.ConstructionMenuCategory.NativeFieldInfoPtr_categoryName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.ConstructionMenuCategory.NativeFieldInfoPtr_categoryName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17004609 RID: 17929
			// (get) Token: 0x0600E316 RID: 58134 RVA: 0x0035BFF8 File Offset: 0x0035A1F8
			// (set) Token: 0x0600E317 RID: 58135 RVA: 0x0006E547 File Offset: 0x0006C747
			public unsafe Sprite categoryIcon
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.ConstructionMenuCategory.NativeFieldInfoPtr_categoryIcon);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.ConstructionMenuCategory.NativeFieldInfoPtr_categoryIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700460A RID: 17930
			// (get) Token: 0x0600E318 RID: 58136 RVA: 0x0035C028 File Offset: 0x0035A228
			// (set) Token: 0x0600E319 RID: 58137 RVA: 0x0006E566 File Offset: 0x0006C766
			public unsafe Button button
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.ConstructionMenuCategory.NativeFieldInfoPtr_button);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.ConstructionMenuCategory.NativeFieldInfoPtr_button), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700460B RID: 17931
			// (get) Token: 0x0600E31A RID: 58138 RVA: 0x0035C058 File Offset: 0x0035A258
			// (set) Token: 0x0600E31B RID: 58139 RVA: 0x0006E585 File Offset: 0x0006C785
			public unsafe RectTransform container
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.ConstructionMenuCategory.NativeFieldInfoPtr_container);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.ConstructionMenuCategory.NativeFieldInfoPtr_container), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700460C RID: 17932
			// (get) Token: 0x0600E31C RID: 58140 RVA: 0x0035C088 File Offset: 0x0035A288
			// (set) Token: 0x0600E31D RID: 58141 RVA: 0x0006E5A4 File Offset: 0x0006C7A4
			public unsafe List<ConstructionMenu.ConstructionMenuListing> listings
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.ConstructionMenuCategory.NativeFieldInfoPtr_listings);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ConstructionMenu.ConstructionMenuListing>>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.ConstructionMenuCategory.NativeFieldInfoPtr_listings), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009828 RID: 38952
			private static readonly System.IntPtr NativeFieldInfoPtr_categoryName;

			// Token: 0x04009829 RID: 38953
			private static readonly System.IntPtr NativeFieldInfoPtr_categoryIcon;

			// Token: 0x0400982A RID: 38954
			private static readonly System.IntPtr NativeFieldInfoPtr_button;

			// Token: 0x0400982B RID: 38955
			private static readonly System.IntPtr NativeFieldInfoPtr_container;

			// Token: 0x0400982C RID: 38956
			private static readonly System.IntPtr NativeFieldInfoPtr_listings;

			// Token: 0x0400982D RID: 38957
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000C19 RID: 3097
		public class ConstructionMenuListing : Il2CppSystem.Object
		{
			// Token: 0x0600E31E RID: 58142 RVA: 0x0035C0B8 File Offset: 0x0035A2B8
			// Note: this type is marked as 'beforefieldinit'.
			static ConstructionMenuListing()
			{
				Il2CppClassPointerStore<ConstructionMenu.ConstructionMenuListing>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ConstructionMenu>.NativeClassPtr, "ConstructionMenuListing");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConstructionMenu.ConstructionMenuListing>.NativeClassPtr);
				ConstructionMenu.ConstructionMenuListing.NativeFieldInfoPtr_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructionMenu.ConstructionMenuListing>.NativeClassPtr, "ID");
				ConstructionMenu.ConstructionMenuListing.NativeFieldInfoPtr_price = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructionMenu.ConstructionMenuListing>.NativeClassPtr, "price");
				ConstructionMenu.ConstructionMenuListing.NativeFieldInfoPtr_category = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructionMenu.ConstructionMenuListing>.NativeClassPtr, "category");
				ConstructionMenu.ConstructionMenuListing.NativeFieldInfoPtr_entry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructionMenu.ConstructionMenuListing>.NativeClassPtr, "entry");
				ConstructionMenu.ConstructionMenuListing.NativeFieldInfoPtr_isSelected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructionMenu.ConstructionMenuListing>.NativeClassPtr, "isSelected");
				ConstructionMenu.ConstructionMenuListing.NativeMethodInfoPtr__ctor_Public_Void_String_Single_ConstructionMenuCategory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionMenu.ConstructionMenuListing>.NativeClassPtr, 100683844);
				ConstructionMenu.ConstructionMenuListing.NativeMethodInfoPtr_CreateUI_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionMenu.ConstructionMenuListing>.NativeClassPtr, 100683845);
				ConstructionMenu.ConstructionMenuListing.NativeMethodInfoPtr_ListingClicked_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionMenu.ConstructionMenuListing>.NativeClassPtr, 100683846);
				ConstructionMenu.ConstructionMenuListing.NativeMethodInfoPtr_ListingUnselected_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionMenu.ConstructionMenuListing>.NativeClassPtr, 100683847);
				ConstructionMenu.ConstructionMenuListing.NativeMethodInfoPtr_SetSelected_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionMenu.ConstructionMenuListing>.NativeClassPtr, 100683848);
			}

			// Token: 0x0600E31F RID: 58143 RVA: 0x0035C1AC File Offset: 0x0035A3AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291909, XrefRangeEnd = 291923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ConstructionMenuListing(string id, float _price, ConstructionMenu.ConstructionMenuCategory _cat) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConstructionMenu.ConstructionMenuListing>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
				ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref _price;
				ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_cat);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionMenu.ConstructionMenuListing.NativeMethodInfoPtr__ctor_Public_Void_String_Single_ConstructionMenuCategory_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600E320 RID: 58144 RVA: 0x0035C218 File Offset: 0x0035A418
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 291975, RefRangeEnd = 291978, XrefRangeStart = 291923, XrefRangeEnd = 291975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void CreateUI()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionMenu.ConstructionMenuListing.NativeMethodInfoPtr_CreateUI_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600E321 RID: 58145 RVA: 0x0035C24C File Offset: 0x0035A44C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291978, XrefRangeEnd = 291995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void ListingClicked()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionMenu.ConstructionMenuListing.NativeMethodInfoPtr_ListingClicked_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600E322 RID: 58146 RVA: 0x0035C280 File Offset: 0x0035A480
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291995, XrefRangeEnd = 291996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void ListingUnselected()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionMenu.ConstructionMenuListing.NativeMethodInfoPtr_ListingUnselected_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600E323 RID: 58147 RVA: 0x0035C2B4 File Offset: 0x0035A4B4
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 292022, RefRangeEnd = 292025, XrefRangeStart = 291996, XrefRangeEnd = 292022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetSelected(bool selected)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref selected;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionMenu.ConstructionMenuListing.NativeMethodInfoPtr_SetSelected_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600E324 RID: 58148 RVA: 0x0006E5C3 File Offset: 0x0006C7C3
			public ConstructionMenuListing(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700460D RID: 17933
			// (get) Token: 0x0600E325 RID: 58149 RVA: 0x0035C2F4 File Offset: 0x0035A4F4
			// (set) Token: 0x0600E326 RID: 58150 RVA: 0x0006E5CC File Offset: 0x0006C7CC
			public unsafe string ID
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.ConstructionMenuListing.NativeFieldInfoPtr_ID);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.ConstructionMenuListing.NativeFieldInfoPtr_ID), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700460E RID: 17934
			// (get) Token: 0x0600E327 RID: 58151 RVA: 0x0035C31C File Offset: 0x0035A51C
			// (set) Token: 0x0600E328 RID: 58152 RVA: 0x0006E5EB File Offset: 0x0006C7EB
			public unsafe float price
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.ConstructionMenuListing.NativeFieldInfoPtr_price);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.ConstructionMenuListing.NativeFieldInfoPtr_price)) = value;
				}
			}

			// Token: 0x1700460F RID: 17935
			// (get) Token: 0x0600E329 RID: 58153 RVA: 0x0035C344 File Offset: 0x0035A544
			// (set) Token: 0x0600E32A RID: 58154 RVA: 0x0006E606 File Offset: 0x0006C806
			public unsafe ConstructionMenu.ConstructionMenuCategory category
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.ConstructionMenuListing.NativeFieldInfoPtr_category);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConstructionMenu.ConstructionMenuCategory>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.ConstructionMenuListing.NativeFieldInfoPtr_category), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004610 RID: 17936
			// (get) Token: 0x0600E32B RID: 58155 RVA: 0x0035C374 File Offset: 0x0035A574
			// (set) Token: 0x0600E32C RID: 58156 RVA: 0x0006E625 File Offset: 0x0006C825
			public unsafe RectTransform entry
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.ConstructionMenuListing.NativeFieldInfoPtr_entry);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.ConstructionMenuListing.NativeFieldInfoPtr_entry), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004611 RID: 17937
			// (get) Token: 0x0600E32D RID: 58157 RVA: 0x0035C3A4 File Offset: 0x0035A5A4
			// (set) Token: 0x0600E32E RID: 58158 RVA: 0x0006E644 File Offset: 0x0006C844
			public unsafe bool isSelected
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.ConstructionMenuListing.NativeFieldInfoPtr_isSelected);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.ConstructionMenuListing.NativeFieldInfoPtr_isSelected)) = value;
				}
			}

			// Token: 0x0400982E RID: 38958
			private static readonly System.IntPtr NativeFieldInfoPtr_ID;

			// Token: 0x0400982F RID: 38959
			private static readonly System.IntPtr NativeFieldInfoPtr_price;

			// Token: 0x04009830 RID: 38960
			private static readonly System.IntPtr NativeFieldInfoPtr_category;

			// Token: 0x04009831 RID: 38961
			private static readonly System.IntPtr NativeFieldInfoPtr_entry;

			// Token: 0x04009832 RID: 38962
			private static readonly System.IntPtr NativeFieldInfoPtr_isSelected;

			// Token: 0x04009833 RID: 38963
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Single_ConstructionMenuCategory_0;

			// Token: 0x04009834 RID: 38964
			private static readonly System.IntPtr NativeMethodInfoPtr_CreateUI_Private_Void_0;

			// Token: 0x04009835 RID: 38965
			private static readonly System.IntPtr NativeMethodInfoPtr_ListingClicked_Private_Void_0;

			// Token: 0x04009836 RID: 38966
			private static readonly System.IntPtr NativeMethodInfoPtr_ListingUnselected_Public_Void_0;

			// Token: 0x04009837 RID: 38967
			private static readonly System.IntPtr NativeMethodInfoPtr_SetSelected_Public_Void_Boolean_0;
		}

		// Token: 0x02000C1A RID: 3098
		[ObfuscatedName("ScheduleOne.UI.Construction.ConstructionMenu+<>c__DisplayClass35_0")]
		public sealed class __c__DisplayClass35_0 : Il2CppSystem.Object
		{
			// Token: 0x0600E32F RID: 58159 RVA: 0x0035C3CC File Offset: 0x0035A5CC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass35_0()
			{
				Il2CppClassPointerStore<ConstructionMenu.__c__DisplayClass35_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ConstructionMenu>.NativeClassPtr, "<>c__DisplayClass35_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConstructionMenu.__c__DisplayClass35_0>.NativeClassPtr);
				ConstructionMenu.__c__DisplayClass35_0.NativeFieldInfoPtr_category = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructionMenu.__c__DisplayClass35_0>.NativeClassPtr, "category");
				ConstructionMenu.__c__DisplayClass35_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionMenu.__c__DisplayClass35_0>.NativeClassPtr, 100683849);
				ConstructionMenu.__c__DisplayClass35_0.NativeMethodInfoPtr__AddListing_b__0_Internal_Boolean_ConstructionMenuCategory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionMenu.__c__DisplayClass35_0>.NativeClassPtr, 100683850);
			}

			// Token: 0x0600E330 RID: 58160 RVA: 0x0035C434 File Offset: 0x0035A634
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass35_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConstructionMenu.__c__DisplayClass35_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionMenu.__c__DisplayClass35_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600E331 RID: 58161 RVA: 0x0035C470 File Offset: 0x0035A670
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _AddListing_b__0(ConstructionMenu.ConstructionMenuCategory x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(ConstructionMenu.__c__DisplayClass35_0.NativeMethodInfoPtr__AddListing_b__0_Internal_Boolean_ConstructionMenuCategory_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600E332 RID: 58162 RVA: 0x0006E65F File Offset: 0x0006C85F
			public __c__DisplayClass35_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004612 RID: 17938
			// (get) Token: 0x0600E333 RID: 58163 RVA: 0x0035C4C0 File Offset: 0x0035A6C0
			// (set) Token: 0x0600E334 RID: 58164 RVA: 0x0006E668 File Offset: 0x0006C868
			public unsafe string category
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.__c__DisplayClass35_0.NativeFieldInfoPtr_category);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.__c__DisplayClass35_0.NativeFieldInfoPtr_category), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04009838 RID: 38968
			private static readonly System.IntPtr NativeFieldInfoPtr_category;

			// Token: 0x04009839 RID: 38969
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400983A RID: 38970
			private static readonly System.IntPtr NativeMethodInfoPtr__AddListing_b__0_Internal_Boolean_ConstructionMenuCategory_0;
		}

		// Token: 0x02000C1B RID: 3099
		[ObfuscatedName("ScheduleOne.UI.Construction.ConstructionMenu+<>c__DisplayClass50_0")]
		public sealed class __c__DisplayClass50_0 : Il2CppSystem.Object
		{
			// Token: 0x0600E335 RID: 58165 RVA: 0x0035C4E8 File Offset: 0x0035A6E8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass50_0()
			{
				Il2CppClassPointerStore<ConstructionMenu.__c__DisplayClass50_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ConstructionMenu>.NativeClassPtr, "<>c__DisplayClass50_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConstructionMenu.__c__DisplayClass50_0>.NativeClassPtr);
				ConstructionMenu.__c__DisplayClass50_0.NativeFieldInfoPtr_catName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructionMenu.__c__DisplayClass50_0>.NativeClassPtr, "catName");
				ConstructionMenu.__c__DisplayClass50_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructionMenu.__c__DisplayClass50_0>.NativeClassPtr, "<>4__this");
				ConstructionMenu.__c__DisplayClass50_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionMenu.__c__DisplayClass50_0>.NativeClassPtr, 100683851);
				ConstructionMenu.__c__DisplayClass50_0.NativeMethodInfoPtr__GenerateCategories_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionMenu.__c__DisplayClass50_0>.NativeClassPtr, 100683852);
			}

			// Token: 0x0600E336 RID: 58166 RVA: 0x0035C564 File Offset: 0x0035A764
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass50_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConstructionMenu.__c__DisplayClass50_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionMenu.__c__DisplayClass50_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600E337 RID: 58167 RVA: 0x0035C5A0 File Offset: 0x0035A7A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292025, XrefRangeEnd = 292027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _GenerateCategories_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionMenu.__c__DisplayClass50_0.NativeMethodInfoPtr__GenerateCategories_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600E338 RID: 58168 RVA: 0x0006E687 File Offset: 0x0006C887
			public __c__DisplayClass50_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004613 RID: 17939
			// (get) Token: 0x0600E339 RID: 58169 RVA: 0x0035C5D4 File Offset: 0x0035A7D4
			// (set) Token: 0x0600E33A RID: 58170 RVA: 0x0006E690 File Offset: 0x0006C890
			public unsafe string catName
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.__c__DisplayClass50_0.NativeFieldInfoPtr_catName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.__c__DisplayClass50_0.NativeFieldInfoPtr_catName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17004614 RID: 17940
			// (get) Token: 0x0600E33B RID: 58171 RVA: 0x0035C5FC File Offset: 0x0035A7FC
			// (set) Token: 0x0600E33C RID: 58172 RVA: 0x0006E6AF File Offset: 0x0006C8AF
			public unsafe ConstructionMenu __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.__c__DisplayClass50_0.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConstructionMenu>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.__c__DisplayClass50_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400983B RID: 38971
			private static readonly System.IntPtr NativeFieldInfoPtr_catName;

			// Token: 0x0400983C RID: 38972
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400983D RID: 38973
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400983E RID: 38974
			private static readonly System.IntPtr NativeMethodInfoPtr__GenerateCategories_b__0_Internal_Void_0;
		}

		// Token: 0x02000C1C RID: 3100
		[ObfuscatedName("ScheduleOne.UI.Construction.ConstructionMenu+<>c__DisplayClass51_0")]
		public sealed class __c__DisplayClass51_0 : Il2CppSystem.Object
		{
			// Token: 0x0600E33D RID: 58173 RVA: 0x0035C62C File Offset: 0x0035A82C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass51_0()
			{
				Il2CppClassPointerStore<ConstructionMenu.__c__DisplayClass51_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ConstructionMenu>.NativeClassPtr, "<>c__DisplayClass51_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConstructionMenu.__c__DisplayClass51_0>.NativeClassPtr);
				ConstructionMenu.__c__DisplayClass51_0.NativeFieldInfoPtr_categoryName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructionMenu.__c__DisplayClass51_0>.NativeClassPtr, "categoryName");
				ConstructionMenu.__c__DisplayClass51_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionMenu.__c__DisplayClass51_0>.NativeClassPtr, 100683853);
				ConstructionMenu.__c__DisplayClass51_0.NativeMethodInfoPtr__SelectCategory_b__0_Internal_Boolean_ConstructionMenuCategory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionMenu.__c__DisplayClass51_0>.NativeClassPtr, 100683854);
			}

			// Token: 0x0600E33E RID: 58174 RVA: 0x0035C694 File Offset: 0x0035A894
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass51_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConstructionMenu.__c__DisplayClass51_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionMenu.__c__DisplayClass51_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600E33F RID: 58175 RVA: 0x0035C6D0 File Offset: 0x0035A8D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _SelectCategory_b__0(ConstructionMenu.ConstructionMenuCategory x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(ConstructionMenu.__c__DisplayClass51_0.NativeMethodInfoPtr__SelectCategory_b__0_Internal_Boolean_ConstructionMenuCategory_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600E340 RID: 58176 RVA: 0x0006E6CE File Offset: 0x0006C8CE
			public __c__DisplayClass51_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004615 RID: 17941
			// (get) Token: 0x0600E341 RID: 58177 RVA: 0x0035C720 File Offset: 0x0035A920
			// (set) Token: 0x0600E342 RID: 58178 RVA: 0x0006E6D7 File Offset: 0x0006C8D7
			public unsafe string categoryName
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.__c__DisplayClass51_0.NativeFieldInfoPtr_categoryName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.__c__DisplayClass51_0.NativeFieldInfoPtr_categoryName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x0400983F RID: 38975
			private static readonly System.IntPtr NativeFieldInfoPtr_categoryName;

			// Token: 0x04009840 RID: 38976
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009841 RID: 38977
			private static readonly System.IntPtr NativeMethodInfoPtr__SelectCategory_b__0_Internal_Boolean_ConstructionMenuCategory_0;
		}
	}
}
